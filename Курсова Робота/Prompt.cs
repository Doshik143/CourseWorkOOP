﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_Робота
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = WindowSettings(caption);
            TextBox textBox = InterfaceElementsForWindow(text, prompt);

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private static TextBox InterfaceElementsForWindow(string text, Form prompt)
        {
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            return textBox;
        }

        private static Form WindowSettings(string caption)
        {
            return new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
        }
    }
}
