using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SFV2RSubtitles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            defaultPostfixTextBox.Text = Properties.Settings.Default.DefaultPostfix;
        }

        #region GUI
        private void okButton_Click(object sender, EventArgs e)
        {
            logRichTextBox.Text = $"Выполняется.\n" +
                                  $"Исходный файл: {inFilePathTextBox.Text}\n" +
                                  $"Итоговый файл: {outFilePathTextBox.Text}\n" +
                                  $"==========\n";


            try
            {
                ProcessFile(inFilePathTextBox.Text, outFilePathTextBox.Text);
            }
            catch (Exception exception)
            {
                logRichTextBox.Text += "ПРОИЗОШЛА ОШИБКА:\n";
                logRichTextBox.Text += exception;
                throw;
            }

            logRichTextBox.Text += "ГОТОВО!";
        }

        private void openSourceFileButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                DialogResult Action = openFileDialog.ShowDialog();
                if (Action == DialogResult.OK)
                {
                    inFilePathTextBox.Text = openFileDialog.FileName;

                    var outFileNameSB = new StringBuilder();
                    var components = openFileDialog.FileName.Split('.');
                    components[components.Length - 2] += Properties.Settings.Default.DefaultPostfix;
                    for (int i = 0; i != components.Length; i++)
                    {
                        outFileNameSB.Append(components[i]);

                        if (i + 1 < components.Length)
                            outFileNameSB.Append(".");
                    }
                    outFilePathTextBox.Text = outFileNameSB.ToString();
                }
            }
        }

        private void selectOutFileButton_Click(object sender, EventArgs e)
        {
            using var saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            outFilePathTextBox.Text = saveFileDialog.FileName;
        }

        private void changeDefaultPostfixButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultPostfix = defaultPostfixTextBox.Text;
            Properties.Settings.Default.Save();
        }
        #endregion

        private static void ProcessFile(string inFilePath, string outFilePath)
        {
            string[] lines = File.ReadAllLines(inFilePath);

            RemoveRoles(lines);
            RemoveEmphasis(lines);

            File.WriteAllLines(outFilePath, lines);
        }

        private static void RemoveRoles(string[] lines)
        {
            Regex regex = new Regex("\\[(.*?)\\] ");

            for (int index = 0; index != lines.Length; ++index)
                lines[index] = regex.Replace(lines[index], "");
        }

        /// <summary>
        /// Смотрим, есть ли на второй и далее позициях заглавные буквы.
        /// Если есть, смотрим следующую букву. Если она не заглавная — эту уменьшаем.
        /// </summary>
        private static void RemoveEmphasis(string[] lines)
        {
            for (int i = 0; i != lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                // Делим строку по пробелу и процессируем каждое слово
                //
                var words = lines[i].Split(' ');

                for (int j = 0; j != words.Length; j++)
                {
                    words[j] = RemoveEmphasisInWord(words[j]);
                }

                // Собираем строку
                var newLineSB = new StringBuilder(words.Length * 2 - 1);
                for (int j = 0; j != words.Length; j++)
                {
                    newLineSB.Append(words[j]);

                    if (j + 1 < words.Length)
                        newLineSB.Append(" ");
                }

                lines[i] = newLineSB.ToString();
            }
        }

        private static string RemoveEmphasisInWord(string word)
        {
            // Случай одного символа, двух символов (если это сокращение)
            if (word.Length <= 2)
                return word;

            if (!char.IsLetter(word[0]) && (!char.IsLetter(word[1])))
                return word;

            //if (ItIsAcronym(word)) // Если это аббревиатура
            //    return word;

            for (int j = 1; // Первая буква нам не интересна, это может быть просто название, например
            j < word.Length - 1; // Последний символ обработаем отдельно
            j++)
            {
                // Если этот символ в верхнем регистре, а следующий за текущим символом символ — в нижнем
                // То у нас не сокращение, а именно выделенный верхним регистром символ

                var currentChar = word[j];

                // Обрабатываем слово в кавычках
                if ((j == 1) && (word[0] == '\"'))
                {
                    continue;
                }


                var nextChar = word[j + 1];
                if ((char.IsUpper(currentChar)) && (char.IsLower(nextChar)))
                {
                    var chars = word.ToCharArray();
                    chars[j] = char.ToLower(currentChar);
                    word = new string(chars);
                }


            }

            // Если последний символ в верхнем регистре, а предыдущий символ — в нижнем, то снова наш случай
            var lastChar = word[word.Length - 1];

            // Обрабатываем слово в кавычках
            if (lastChar == '\"')
                return word;

            var charBeforeLastChar = word[word.Length - 2];
            if ((char.IsUpper(lastChar)) && (char.IsLower(charBeforeLastChar)))
            {
                var chars = word.ToCharArray();
                chars[word.Length - 1] = char.ToLower(lastChar);
                word = chars.ToString();
            }

            return word;
        }

        private static bool ItIsAcronym(string word)
        {
            var chars = word.ToCharArray();

            foreach (var symbol in chars)
            {
                if (symbol == '\"')
                    continue;

                if (char.IsLower(symbol))
                    return false;
            }

            return true;
        }

    }
}
