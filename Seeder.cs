using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Seeder2
{
    public partial class Seeder : Form
    {
        #region Variables
        public Seeder()
        {
            InitializeComponent();
        }
        int mode = 0;
        public List<int> key = new List<int>();
        public int count = 0;
        public string tstr = "";
        public string output = "";
        public int where = 0;
        #endregion

        private void buttonEK_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.RestoreDirectory = true;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openEK(ofd.FileName);
            }
        }

        void openEK(string path)
        {
            key.Clear();
            StreamReader sr;
            try
            {
                sr = new StreamReader(path);
            }
            catch
            {
                buttonEnc.Enabled = false;
                buttonDec.Enabled = false;
                linkLabel1.Text = "";
                key.Clear();
                MessageBox.Show("Seems to be some misunderstanding, I cannot find that file.\nHave you moved it?", "Error0");
                return;
            }
            try
            {
                foreach (string line in sr.ReadToEnd().Split('\n'))
                {
                    string lnkey = line.Trim();
                    if (!(int.Parse(lnkey) >= 0 && int.Parse(lnkey) <= 200))
                    {
                        buttonEnc.Enabled = false;
                        buttonDec.Enabled = false;
                        linkLabel1.Text = "";
                        key.Clear();
                        MessageBox.Show("Are you sure all the numbers are between 0 and 200 (inclusive)?\nMaybe double-check that one.", "Error4");
                        return;
                    }
                    key.Add(int.Parse(lnkey));
                    if (key.Distinct().Count() != key.Count())
                    {
                        buttonEnc.Enabled = false;
                        buttonDec.Enabled = false;
                        linkLabel1.Text = "";
                        key.Clear();
                        MessageBox.Show("A number seems to be repeated repeated.\nAre you sure sure that each value is only listed once?", "Error3");
                        return;
                    }
                }
            }
            catch
            {
                buttonEnc.Enabled = false;
                buttonDec.Enabled = false;
                linkLabel1.Text = "";
                key.Clear();
                MessageBox.Show("Something just doesn't seem right about that file.\nAre you sure there are only numbers in it?", "Error1");
                return;
            }

            if (key.Count != 97)
            {
                buttonEnc.Enabled = false;
                buttonDec.Enabled = false;
                linkLabel1.Text = "";
                key.Clear();
                MessageBox.Show("Seems like you need some help counting.\nThere should be exactly 97 lines in that text file.", "Error2");
                return;
            }
            Properties.Settings.Default.path = path;
            Properties.Settings.Default.Save();
            linkLabel1.Text = path;
            buttonEnc.Enabled = true;
            buttonDec.Enabled = true;
        }

        private void buttonEnc_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            label4.Visible = true;
            label4.BringToFront();
            label3.Visible = true;
            richTextBox2.Clear();
            buttonEK.Enabled = false;
            buttonDec.Enabled = false;
            buttonEnc.Enabled = false;
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            mode = 1;
            count = 0;
            tstr = "";
            output = "";
            where = 0;
            progressBar1.Value = 0;
            label4.Text = "0%";
            Application.DoEvents();
            foreach (char c in richTextBox1.Text.ToCharArray())
            {
                where++;
                switch (c)
                {
                    case 'A':
                        tchar(0);
                        break;
                    case 'B':
                        tchar(1);
                        break;
                    case 'C':
                        tchar(2);
                        break;
                    case 'D':
                        tchar(3);
                        break;
                    case 'E':
                        tchar(4);
                        break;
                    case 'F':
                        tchar(5);
                        break;
                    case 'G':
                        tchar(6);
                        break;
                    case 'H':
                        tchar(7);
                        break;
                    case 'I':
                        tchar(8);
                        break;
                    case 'J':
                        tchar(9);
                        break;
                    case 'K':
                        tchar(10);
                        break;
                    case 'L':
                        tchar(11);
                        break;
                    case 'M':
                        tchar(12);
                        break;
                    case 'N':
                        tchar(13);
                        break;
                    case 'O':
                        tchar(14);
                        break;
                    case 'P':
                        tchar(15);
                        break;
                    case 'Q':
                        tchar(16);
                        break;
                    case 'R':
                        tchar(17);
                        break;
                    case 'S':
                        tchar(18);
                        break;
                    case 'T':
                        tchar(19);
                        break;
                    case 'U':
                        tchar(20);
                        break;
                    case 'V':
                        tchar(21);
                        break;
                    case 'W':
                        tchar(22);
                        break;
                    case 'X':
                        tchar(23);
                        break;
                    case 'Y':
                        tchar(24);
                        break;
                    case 'Z':
                        tchar(25);
                        break;
                    case 'a':
                        tchar(26);
                        break;
                    case 'b':
                        tchar(27);
                        break;
                    case 'c':
                        tchar(28);
                        break;
                    case 'd':
                        tchar(29);
                        break;
                    case 'e':
                        tchar(30);
                        break;
                    case 'f':
                        tchar(31);
                        break;
                    case 'g':
                        tchar(32);
                        break;
                    case 'h':
                        tchar(33);
                        break;
                    case 'i':
                        tchar(34);
                        break;
                    case 'j':
                        tchar(35);
                        break;
                    case 'k':
                        tchar(36);
                        break;
                    case 'l':
                        tchar(37);
                        break;
                    case 'm':
                        tchar(38);
                        break;
                    case 'n':
                        tchar(39);
                        break;
                    case 'o':
                        tchar(40);
                        break;
                    case 'p':
                        tchar(41);
                        break;
                    case 'q':
                        tchar(42);
                        break;
                    case 'r':
                        tchar(43);
                        break;
                    case 's':
                        tchar(44);
                        break;
                    case 't':
                        tchar(45);
                        break;
                    case 'u':
                        tchar(46);
                        break;
                    case 'v':
                        tchar(47);
                        break;
                    case 'w':
                        tchar(48);
                        break;
                    case 'x':
                        tchar(49);
                        break;
                    case 'y':
                        tchar(50);
                        break;
                    case 'z':
                        tchar(51);
                        break;
                    case '1':
                        tchar(52);
                        break;
                    case '2':
                        tchar(53);
                        break;
                    case '3':
                        tchar(54);
                        break;
                    case '4':
                        tchar(55);
                        break;
                    case '5':
                        tchar(56);
                        break;
                    case '6':
                        tchar(57);
                        break;
                    case '7':
                        tchar(58);
                        break;
                    case '8':
                        tchar(59);
                        break;
                    case '9':
                        tchar(60);
                        break;
                    case '0':
                        tchar(61);
                        break;
                    case '!':
                        tchar(62);
                        break;
                    case '@':
                        tchar(63);
                        break;
                    case '#':
                        tchar(64);
                        break;
                    case '$':
                        tchar(65);
                        break;
                    case '%':
                        tchar(66);
                        break;
                    case '^':
                        tchar(67);
                        break;
                    case '&':
                        tchar(68);
                        break;
                    case '*':
                        tchar(69);
                        break;
                    case '(':
                        tchar(70);
                        break;
                    case ')':
                        tchar(71);
                        break;
                    case '`':
                        tchar(72);
                        break;
                    case '~':
                        tchar(73);
                        break;
                    case '-':
                        tchar(74);
                        break;
                    case '=':
                        tchar(75);
                        break;
                    case '_':
                        tchar(76);
                        break;
                    case '+':
                        tchar(77);
                        break;
                    case '[':
                        tchar(78);
                        break;
                    case ']':
                        tchar(79);
                        break;
                    case '\\':
                        tchar(80);
                        break;
                    case ';':
                        tchar(81);
                        break;
                    case '\'':
                        tchar(82);
                        break;
                    case ',':
                        tchar(83);
                        break;
                    case '.':
                        tchar(84);
                        break;
                    case '/':
                        tchar(85);
                        break;
                    case '{':
                        tchar(86);
                        break;
                    case '}':
                        tchar(87);
                        break;
                    case '|':
                        tchar(88);
                        break;
                    case ':':
                        tchar(89);
                        break;
                    case '\"':
                        tchar(90);
                        break;
                    case '<':
                        tchar(91);
                        break;
                    case '>':
                        tchar(92);
                        break;
                    case '?':
                        tchar(93);
                        break;
                    case ' ':
                        tchar(94);
                        break;
                    case '\n':
                        tchar(95);
                        break;
                    case '\r':
                        tchar(95);
                        break;

                    default:
                        tchar(96);
                        break;
                }
            }
            while (count != 0)
            {
                tchar(96);
            }
            richTextBox2.Text = output;
            mode = 0;
            progressBar1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            buttonEK.Enabled = true;
            buttonDec.Enabled = true;
            buttonEnc.Enabled = true;
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = true;
        }

        void tchar(int i)
        {
            if (mode == 1) /// Encrypt
            {
                string tmp = key[i].ToString();
                while (tmp.Length < 3)
                {
                    tmp = "0" + tmp;
                }
                count++;
                tstr += tmp;
                if (count == 3)
                {
                    count = 0;
                    part1();
                }
            }
        }

        void part1()
        {
            string tmp = int.Parse(tstr).ToString("X");
            while (tmp.Length < 7)
            {
                tmp = "0" + tmp;
            }
            tstr = "";
            string tmp0 = "";
            int tmplng = randomiser();
            while (tmplng <= 0)
            {
                new ManualResetEvent(false).WaitOne(5);
                tmplng = randomiser();
            }
            Random r = new Random(Interlocked.Increment(ref tmplng));
            char[] s = "abcdefghijklmnopqrstuvwxyzGHIJKLMNOPQRSTUVWXYZ`-=~!@#$%^&*()_+[]\\{}|;':\",./<>? ".ToCharArray();
            for (int i = 0; i < r.Next(72); i++)
            {
                tmp0 += s[r.Next(79)];

            }
            foreach (char c in tmp)
            {
                tmp0 += c.ToString();
                for (int i = 0; i < r.Next(72); i++)
                {
                    tmp0 += s[r.Next(79)];
                }
            }
            output += tmp0;
            progressBar1.Value = 100 * where / richTextBox1.TextLength;
            label4.Text = (double)100 * where / richTextBox1.TextLength + "%";
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            buttonEK.Enabled = false;
            buttonDec.Enabled = false;
            buttonEnc.Enabled = false;
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            mode = 2;
            count = 0;
            tstr = "";
            output = "";
            string aL = "ABCDEF1234567890";
            foreach (char c in richTextBox1.Text.ToCharArray())
            {
                if (aL.Contains(c.ToString()))
                {
                    tstr += c.ToString();
                }
            }
            foreach (string s in Enumerable.Range(0, tstr.Length / 7)
        .Select(i => tstr.Substring(i * 7, 7)))
            {
                string temp0 = int.Parse(s, System.Globalization.NumberStyles.HexNumber).ToString();
                while (temp0.Length < 9)
                {
                    temp0 = "0" + temp0;
                }
                foreach (string i in Enumerable.Range(0, temp0.ToString().Length / 3)
        .Select(i => temp0.ToString().Substring(i * 3, 3)))
                {
                    string temp1 = int.Parse(i).ToString();
                    int match1 = key.FindIndex(x => x.ToString() == temp1);
                    switch (match1)
                    {
                        case 0:
                            output += "A";
                            break;
                        case 1:
                            output += "B";
                            break;
                        case 2:
                            output += "C";
                            break;
                        case 3:
                            output += "D";
                            break;
                        case 4:
                            output += "E";
                            break;
                        case 5:
                            output += "F";
                            break;
                        case 6:
                            output += "G";
                            break;
                        case 7:
                            output += "H";
                            break;
                        case 8:
                            output += "I";
                            break;
                        case 9:
                            output += "J";
                            break;
                        case 10:
                            output += "K";
                            break;
                        case 11:
                            output += "L";
                            break;
                        case 12:
                            output += "M";
                            break;
                        case 13:
                            output += "N";
                            break;
                        case 14:
                            output += "O";
                            break;
                        case 15:
                            output += "P";
                            break;
                        case 16:
                            output += "Q";
                            break;
                        case 17:
                            output += "R";
                            break;
                        case 18:
                            output += "S";
                            break;
                        case 19:
                            output += "T";
                            break;
                        case 20:
                            output += "U";
                            break;
                        case 21:
                            output += "V";
                            break;
                        case 22:
                            output += "W";
                            break;
                        case 23:
                            output += "X";
                            break;
                        case 24:
                            output += "Y";
                            break;
                        case 25:
                            output += "Z";
                            break;
                        case 26:
                            output += "a";
                            break;
                        case 27:
                            output += "b";
                            break;
                        case 28:
                            output += "c";
                            break;
                        case 29:
                            output += "d";
                            break;
                        case 30:
                            output += "e";
                            break;
                        case 31:
                            output += "f";
                            break;
                        case 32:
                            output += "g";
                            break;
                        case 33:
                            output += "h";
                            break;
                        case 34:
                            output += "i";
                            break;
                        case 35:
                            output += "j";
                            break;
                        case 36:
                            output += "k";
                            break;
                        case 37:
                            output += "l";
                            break;
                        case 38:
                            output += "m";
                            break;
                        case 39:
                            output += "n";
                            break;
                        case 40:
                            output += "o";
                            break;
                        case 41:
                            output += "p";
                            break;
                        case 42:
                            output += "q";
                            break;
                        case 43:
                            output += "r";
                            break;
                        case 44:
                            output += "s";
                            break;
                        case 45:
                            output += "t";
                            break;
                        case 46:
                            output += "u";
                            break;
                        case 47:
                            output += "v";
                            break;
                        case 48:
                            output += "w";
                            break;
                        case 49:
                            output += "x";
                            break;
                        case 50:
                            output += "y";
                            break;
                        case 51:
                            output += "z";
                            break;
                        case 52:
                            output += "1";
                            break;
                        case 53:
                            output += "2";
                            break;
                        case 54:
                            output += "3";
                            break;
                        case 55:
                            output += "4";
                            break;
                        case 56:
                            output += "5";
                            break;
                        case 57:
                            output += "6";
                            break;
                        case 58:
                            output += "7";
                            break;
                        case 59:
                            output += "8";
                            break;
                        case 60:
                            output += "9";
                            break;
                        case 61:
                            output += "0";
                            break;
                        case 62:
                            output += "!";
                            break;
                        case 63:
                            output += "@";
                            break;
                        case 64:
                            output += "#";
                            break;
                        case 65:
                            output += "$";
                            break;
                        case 66:
                            output += "%";
                            break;
                        case 67:
                            output += "^";
                            break;
                        case 68:
                            output += "&";
                            break;
                        case 69:
                            output += "*";
                            break;
                        case 70:
                            output += "(";
                            break;
                        case 71:
                            output += ")";
                            break;
                        case 72:
                            output += "`";
                            break;
                        case 73:
                            output += "~";
                            break;
                        case 74:
                            output += "-";
                            break;
                        case 75:
                            output += "=";
                            break;
                        case 76:
                            output += "_";
                            break;
                        case 77:
                            output += "+";
                            break;
                        case 78:
                            output += "[";
                            break;
                        case 79:
                            output += "]";
                            break;
                        case 80:
                            output += "\\";
                            break;
                        case 81:
                            output += ":";
                            break;
                        case 82:
                            output += "\'";
                            break;
                        case 83:
                            output += ",";
                            break;
                        case 84:
                            output += ".";
                            break;
                        case 85:
                            output += "/";
                            break;
                        case 86:
                            output += "{";
                            break;
                        case 87:
                            output += "}";
                            break;
                        case 88:
                            output += "|";
                            break;
                        case 89:
                            output += ":";
                            break;
                        case 90:
                            output += "\"";
                            break;
                        case 91:
                            output += "<";
                            break;
                        case 92:
                            output += ">";
                            break;
                        case 93:
                            output += "?";
                            break;
                        case 94:
                            output += " ";
                            break;
                        case 95:
                            output += "\n";
                            break;
                        case 96:
                            output += "";
                            break;
                        default:
                            output += "";
                            break;
                    }
                }
            }


            richTextBox2.Text = output;
            mode = 0;
            buttonEK.Enabled = true;
            buttonDec.Enabled = true;
            buttonEnc.Enabled = true;
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = true;
        }

        private void Seeder_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.path.Trim() != "")
            {
                openEK(Properties.Settings.Default.path);
            }
            label4.Left = ((Width - label4.Width) / 2) - 50;
            label3.Left = (Width - label3.Width) / 2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Properties.Settings.Default.path.Trim() != "")
            {
                System.Diagnostics.Process.Start("explorer.exe", $"/select, \"{Properties.Settings.Default.path.Trim()}\"");
            }
        }

        #region Randomizer
        //private void button1_Click(object sender, EventArgs e)
        int randomiser()
        {
            Point cursorPos = Cursor.Position;

            // Create a random number generator
            Random random = new Random();

            // Move the cursor in subpixel increments for 10 times
            //for (int i = 0; i < 10; i++)
            //{
            //    // Generate a random subpixel offset between -0.5 and 0.5
            //    double offsetX = random.NextDouble() - 0.5;
            //    double offsetY = random.NextDouble() - 0.5;

            //    // Convert the offset to screen coordinates
            //    // The screen coordinates range from 0 to 65535
            //    int dx = (int)(offsetX * 65536);
            //    int dy = (int)(offsetY * 65536);

            //    // Create an INPUT structure for mouse input
            //    INPUT input = new INPUT
            //    {
            //        dwType = 0, // Mouse input
            //        mi = new MOUSEINPUT
            //        {
            //            dx = dx,
            //            dy = dy,
            //            mouseData = 0,
            //            dwFlags = MOUSEEVENTF_MOVE | MOUSEEVENTF_ABSOLUTE,
            //            time = 0,
            //            dwExtraInfo = IntPtr.Zero
            //        }
            //    };

            //    // Send the mouse input
            //    //SendInput(1, input, Marshal.SizeOf(input));

            //    // Wait
            new ManualResetEvent(false).WaitOne(1);
            //}

            // Get the new cursor position
            Point newCursorPos = Cursor.Position;

            // Calculate the distance between the old and new cursor positions
            double distance = Math.Sqrt(Math.Pow(newCursorPos.X - cursorPos.X, 2) + Math.Pow(newCursorPos.Y - cursorPos.Y, 2));

            // Generate a random number based on the distance
            // You can use any hash function or algorithm you prefer
            int randomNumber = (int)((long)(distance * 1000000000) / 256);
            return randomNumber;
        }
        // Define the INPUT structure for mouse input
        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        // Define the INPUT structure for input type
        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            public uint dwType;
            public MOUSEINPUT mi;
        }

        // Import the SendInput function from user32.dll
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint cInputs, INPUT input, int size);

        // Define the mouse input flags
        const int MOUSEEVENTF_MOVE = 0x0001; // Mouse move
        const int MOUSEEVENTF_ABSOLUTE = 0x8000; // Absolute move
        #endregion

        private void Seeder_Resize(object sender, EventArgs e)
        {
            label4.Left = ((Width - label4.Width) / 2) - 50;
            label3.Left = (Width - label3.Width) / 2;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyFromOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox2.Text.ToString());
        }

        private void pasteToInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seeder 2\nVersion: " + ProductVersion + " - Dec/11/2023");
        }
    }
}
