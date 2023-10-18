namespace Translator_Morse_Code
{
    public partial class HomeForm : Form
    {
        private Dictionary<char, string> morseABC = new Dictionary<char, string>();
        public HomeForm()
        {
            InitializeComponent();
            InitDict();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            translatedTextBox.Text = Translate(Checker(translateTextBox.Text));
        }

        private void InitDict()
        {
            morseABC.Add('A', "*_");
            morseABC.Add('B', "_***");
            morseABC.Add('C', "_*_*");
            morseABC.Add('D', "_**");
            morseABC.Add('E', "*");
            morseABC.Add('F', "**_*");
            morseABC.Add('G', "__*");
            morseABC.Add('H', "****");
            morseABC.Add('I', "**");
            morseABC.Add('J', "*___");
            morseABC.Add('K', "_*_");
            morseABC.Add('L', "*_**");
            morseABC.Add('M', "__");
            morseABC.Add('N', "_*");
            morseABC.Add('O', "___");
            morseABC.Add('P', "*__*");
            morseABC.Add('Q', "__*_");
            morseABC.Add('R', "*_*");
            morseABC.Add('S', "***");
            morseABC.Add('T', "_");
            morseABC.Add('U', "**_");
            morseABC.Add('V', "***_");
            morseABC.Add('W', "*__");
            morseABC.Add('X', "_**_");
            morseABC.Add('Y', "_*__");
            morseABC.Add('Z', "__**");
            morseABC.Add('1', "*____");
            morseABC.Add('2', "**___");
            morseABC.Add('3', "***__");
            morseABC.Add('4', "****_");
            morseABC.Add('5', "*****");
            morseABC.Add('6', "_****");
            morseABC.Add('7', "__***");
            morseABC.Add('8', "___**");
            morseABC.Add('9', "____*");
            morseABC.Add('0', "_____");
        }

        private string Translate(string? translate)
        {
            if (translate == null)
                return "Empty string!";

            string translation = "";
            
            foreach(char c in translate)
            {             
                if(morseABC.ContainsKey(c))
                {
                    translation = translation + " " + morseABC[c];
                }
                else if (c == ' ')
                {
                    translation = translation + "   ";
                }
                else
                {
                    translation = "Translation got corrupted!";
                    return translation;
                }
            }

            translation = translation.Remove(0, 1);

            return translation;
        }

        private string? Checker(string text)
        {
            if (String.IsNullOrWhiteSpace(text))
                return null;

            return text.ToUpper();
        }
    }
}