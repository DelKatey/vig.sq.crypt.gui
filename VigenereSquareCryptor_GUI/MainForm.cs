using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VigenereSquareCryptor_GUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		private static readonly string[] AlphabetList = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
													"L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", 
													"W", "X", "Y", "Z" };
        private static readonly string AlphabetString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static string ExpandKey(string cipherOrPlainText, string keyword)
        {
            if (keyword.Length < cipherOrPlainText.Length)
            {
                string tempKey = keyword;

                while (cipherOrPlainText.Length > tempKey.Length)
                {
                    tempKey += keyword;
                }

                if (tempKey.Length > cipherOrPlainText.Length)
                {
                    tempKey = tempKey.Substring(0, cipherOrPlainText.Length);
                }

                return tempKey;
            }
            else if (keyword.Length == cipherOrPlainText.Length)
                return keyword;
            else
                return "Keyword too long!";
        }

        private static string RecaseAlpha(string convertedText, string originalText)
        {
            string tempStore = "";

            for (int ii = 0; ii < originalText.Length; ii++)
            {
                if (char.IsUpper(originalText[ii]))
                    tempStore += convertedText[ii].ToString().ToUpper();
                else
                    tempStore += convertedText[ii].ToString().ToLower();
            }

            return tempStore;
        }

        private static string ReplaceSpaces(string convertedText, string originalText)
        {
            string sTemp = convertedText;
            string sTemp2 = convertedText;

            for (int ii = 0; ii < originalText.Length; ii++)
            {
                if (originalText[ii].ToString() == " ")
                {
                    sTemp = sTemp.Substring(0, ii) + " " + sTemp2.Substring(ii);
                }

                sTemp2 = sTemp;
            }

            return sTemp;
        }

        private static string ReplaceAllNonAlpha(string convertedText, string originalText)
        {
            string sTemp = convertedText;
            string sTemp2 = convertedText;
            string sTemp3 = convertedText;

            for (int ii = 0; ii < originalText.Length; ii++)
            {
                if (!OnlyLetters(originalText[ii].ToString()))
                {
                    sTemp2 = sTemp.Substring(0, ii);
                    sTemp3 = sTemp.Substring(ii);

                    sTemp = sTemp2 + originalText[ii].ToString() + sTemp3;
                }
            }

            return sTemp;
        }

        private static bool OnlyLetters(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, @"^[a-zA-Z]+$");
        }

        private static string RemoveNonAlpha(string sInput)
        {
            return Regex.Replace(sInput, "[^a-zA-Z0-9 -]", "");
        }

        private static string RemoveSpaces(string sInput)
        {
            return Regex.Replace(sInput, " ", "");
        }

        private static string RemoveAllNonAlpha(string sInput)
        {
            return RemoveNonAlpha(RemoveSpaces(sInput));
        }

        private static string GetNewAlphaString(string iChar)
        {
            if (iChar.Length == 1)
                return AlphabetString.Substring((NeverOver26(GetNumericFromLetter(iChar)) - 1)) + AlphabetString.Substring(0, (NeverOver26(GetNumericFromLetter(iChar)) - 1));
            else
                return "Invalid character!";
        }

        private static string[] GetNewAlphaList(string iChar)
        {
            char[] AlphaCharArray = GetNewAlphaString(iChar).ToCharArray();

            List<string> tempListAppend = new List<string>();

            for (int ii = 0; ii < AlphaCharArray.Length; ii++)
            {
                tempListAppend.Add(AlphaCharArray[ii].ToString());
            }

            return tempListAppend.ToArray();
        }

        private static string GetAlphaFromNumber(int number)
        {//http://stackoverflow.com/questions/1951517/convert-a-to-1-b-to-2-z-to-26-and-then-aa-to-27-ab-to-28-column-indexes-to
            string sString = "";
            decimal iNumber = number + 1;
            while (iNumber > 0)
            {
                decimal currentLetterNumber = (iNumber - 1) % 26;
                char currentLetter = (char)(currentLetterNumber + 65);
                sString = currentLetter + sString;
                iNumber = (iNumber - (currentLetterNumber + 1)) / 26;
            }
            return sString;
        }

        private static int GetNumericFromLetter(string letter)
        {
            //http://stackoverflow.com/questions/1951517/convert-a-to-1-b-to-2-z-to-26-and-then-aa-to-27-ab-to-28-column-indexes-to
            if (letter.Length == 1)
            {
                int retVal = 0;
                string col = letter.ToUpper();
                for (int iChar = col.Length - 1; iChar >= 0; iChar--)
                {
                    char colPiece = col[iChar];
                    int colNum = colPiece - 64;
                    retVal = retVal + colNum * (int)Math.Pow(26, col.Length - (iChar + 1));
                }
                return retVal;
            }
            else
                return 0;
        }

        private static int NeverOver26(int iValue)
        {
            if (iValue > 26)
                return iValue - 26;
            else
                return iValue;
        }

        public static string Decrypt(string ciphertext, string keyword)
        {
            //Broken, non deciphering
            string tempStore = "";
            string KeyToUse = ExpandKey(RemoveAllNonAlpha(ciphertext), keyword);
            string[] tempList;

            for (int ii = 0; ii < RemoveAllNonAlpha(ciphertext).Length; ii++)
            {
                tempList = GetNewAlphaList(KeyToUse[ii].ToString());

                for (int iii = 0; iii < tempList.Length; iii++)
                {
                    //string FromList = tempList[iii].ToString().ToLower();
                    //string FromCipher = RemoveAllNonAlpha(ciphertext)[ii].ToString().ToLower();
                    if (tempList[iii].ToString().ToLower() == RemoveAllNonAlpha(ciphertext)[ii].ToString().ToLower())
                    {
                        tempStore += GetAlphaFromNumber(iii).ToLower();//GetAlphaFromNumber(iii).ToLower();
                        break;
                    }
                }
            }

            return RecaseAlpha(ReplaceAllNonAlpha(tempStore, ciphertext), ciphertext);
        }

        public static string Encrypt(string plaintext, string keyword)
        {
            string tempStore = "";
            string KeyToUse = ExpandKey(RemoveAllNonAlpha(plaintext), keyword);
            string[] tempList;
            int iSelector = 0;

            for (int ii = 0; ii < RemoveAllNonAlpha(plaintext).Length; ii++)
            {
                tempList = GetNewAlphaList(KeyToUse[ii].ToString());
                if (RemoveAllNonAlpha(plaintext)[ii].ToString() != " ")
                {
                    iSelector = NeverOver26(GetNumericFromLetter(RemoveAllNonAlpha(plaintext)[ii].ToString())) - 1;

                    tempStore += tempList[iSelector].ToLower();
                }
                else
                {
                    tempStore += " ";
                }
            }

            return RecaseAlpha(ReplaceAllNonAlpha(tempStore, plaintext), plaintext);
        }
		
		void DoButtonClick(object sender, EventArgs e)
		{
			if (eRadioButton.Checked)
				resultTB.Text = Encrypt(inputTB.Text, keyTB.Text);
			else
				resultTB.Text = Decrypt(inputTB.Text, keyTB.Text);
		}
		
		void AboutButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("Coded by: Delaney, Katie" + Environment.NewLine + "Version: 1.0" + Environment.NewLine + "Time taken: 7 hours", "About this Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
