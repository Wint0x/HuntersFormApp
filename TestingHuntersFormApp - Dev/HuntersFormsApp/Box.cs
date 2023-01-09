using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntersFormsApp
{
    public static class Box
    {
        public static void ErrorBox(params string[] args)
        {

            string message = null;
            string title = null;

            if (args.Count() != 2)
            {
                throw new ArgumentException("Argument count error, only 2 accepted");
            }
            message = args[0];
            title = args[1];

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        public static void SuccessBox(params string[] args)
        {

            string message = null;
            string title = null;

            if (args.Count() != 2)
            {
                throw new ArgumentException("Argument count error, only 2 accepted");
            }
            message = args[0];
            title = args[1];

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

            return;
        }

        public static void WarningBox(params string[] args)
        {

            string message = null;
            string title = null;

            if (args.Count() != 2)
            {
                throw new ArgumentException("Argument count error, only 2 accepted");
            }
            message = args[0];
            title = args[1];

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return;
        }
    }
}
