using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavaCar
{
    public  class Herramientas
    {
        const string EmailRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

        //valida el email
        public static bool ValidarEmail(string email)
        {
            if (email != null)
            {
                return Regex.IsMatch(email, EmailRegex);
            }
            else
            {
                return false;
            }

        }


        private static char g_Gen_DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString());


        //herramienta que permite numeros
        public static bool CaracteresNumeros(System.Windows.Forms.KeyPressEventArgs c, bool SoloEnteros = true)
        {
            //En el caso que presione enter acepta el valor y devuelve True
            int Asc = (int)Keys.Enter;

            if (c.KeyChar == Asc)
            {
                return true;
            }
            if (SoloEnteros == false)
            {
                if (c.KeyChar.ToString() == (".") | c.KeyChar.ToString() == (","))
                {
                    c.KeyChar = g_Gen_DecimalSeparator;
                    return false;
                }
            }

            if (!(char.IsDigit(c.KeyChar)) & !(c.KeyChar == Convert.ToChar(Keys.Back)) & !(c.KeyChar == Convert.ToChar(Keys.Enter)))
            { return true; }
            else
            { return false; }

        }

        //Herramienta que permite letras y numeros
        public static bool CaracteresTexto(System.Windows.Forms.KeyPressEventArgs c, bool Mayusculas = false, bool Minisculas = false)
        {
            bool ret = false;

            if (Mayusculas)
            { c.KeyChar = char.ToUpper(c.KeyChar); }

            if (Minisculas)
            { c.KeyChar = char.ToLower(c.KeyChar); }

            if (!(char.IsLetterOrDigit(c.KeyChar)) & !(char.IsPunctuation(c.KeyChar)) & !(c.KeyChar == Convert.ToChar(Keys.Back)) & !(c.KeyChar == Convert.ToChar(Keys.Space)) & !(c.KeyChar == Convert.ToChar(Keys.Enter)))
                ret = true;
            else
                ret = false;
            return
            ret;

        }


        public static void CaracteresTextoM(KeyPressEventArgs pE)
        {

            if (char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }


        }
    }
}
