﻿/* UserInterface.cs
 * Author: Rod Howell
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// A GUI for a simple text editor.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The history of edits that can be undone.
        /// </summary>
        private Stack _editHistory = new Stack();

        /// <summary>
        /// The history of undos that can be redone.
        /// </summary>
        private Stack _undoHistory = new Stack();

        /// <summary>
        /// The last text seen in the editor.
        /// </summary>
        private string _lastText = "";

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a Click event on the "Open . . ." file menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    uxEditBuffer.Text = File.ReadAllText(uxOpenDialog.FileName);
                    _lastText = uxEditBuffer.Text;
                    _editHistory.Clear();
                    _undoHistory.Clear();
                    uxUndo.Enabled = false;
                    uxRedo.Enabled = false;
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        /// <summary>
        /// Handles a Click event on the "Save As . . ." file menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(uxSaveDialog.FileName, uxEditBuffer.Text);
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        /// <summary>
        /// Displays the given exception to the user.
        /// </summary>
        /// <param name="e">The exception to show.</param>
        private void ShowError(Exception e)
        {
            MessageBox.Show("The following error occurred: " + e);
        }

        /// <summary>
        /// Rotates the given character c n positions through the alphabet whose first
        /// letter is firstLetter and whose number of letters is alphabetLen. alphabetLen
        /// must be positive.
        /// </summary>
        /// <param name="c">The character to rotate.</param>
        /// <param name="n">The number of positions to rotate c.</param>
        /// <param name="firstLetter">The first letter of the alphabet.</param>
        /// <param name="alphabetLen">The number of letters in the alphabet.</param>
        /// <returns>The result of the rotation.</returns>
        private char Rotate(char c, int n, char firstLetter, int alphabetLen)
        {
            return (char)(firstLetter + (c - firstLetter + n) % alphabetLen);
        }

        /// <summary>
        /// Encrypts the given character.
        /// </summary>
        /// <param name="c">The character to encrypt.</param>
        /// <returns>The encrypted character.</returns>
        private char Encrypt(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return Rotate(c, 13, 'a', 26);
            }
            else if (c >= 'A' && c <= 'Z')
            {
                return Rotate(c, 13, 'A', 26);
            }
            else
            {
                return c;
            }
        }

        /// <summary>
        /// Handles a Click event on the "With String" menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEncryptWithString_Click(object sender, EventArgs e)
        {
            string text = uxEditBuffer.Text;
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                result += Encrypt(text[i]);
            }
            uxEditBuffer.Text = result;
        }

        /// <summary>
        /// Handles a Click event on the "With StringBuilder" menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEncryptWithStringBuilder_Click(object sender, EventArgs e)
        {
            string text = uxEditBuffer.Text;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                result.Append(Encrypt(text[i]));
            }
            uxEditBuffer.Text = result.ToString();
        }

        /// <summary>
        /// Records an edit made by the user.
        /// </summary>
        private void RecordEdit()
        {
            bool isDel = IsDeletion(uxEditBuffer, _lastText); // Indicates whether the edit was a deletion
            int len = GetEditLength(uxEditBuffer, _lastText); // The length of the string inserted or deleted
            int loc = GetEditLocation(uxEditBuffer, isDel, len); // The location of the edit
            string text = uxEditBuffer.Text; // The current editor content
            string editStr = GetEditString(text, _lastText, isDel, loc, len); // The string deleted or inserted
            _lastText = text;
            _editHistory.Push(isDel);
            _editHistory.Push(loc);
            _editHistory.Push(editStr);
            _undoHistory.Clear();
            uxUndo.Enabled = true;
            uxRedo.Enabled = false;
        }

        /// <summary>
        /// Returns whether text was deleted from the given string in order to obtain the contents
        /// of the given TextBox.
        /// </summary>
        /// <param name="editor">The TextBox containing the result of the edit.</param>
        /// <param name="lastContent">The string representing the text prior to the edit.</param>
        /// <returns>Whether the edit was a deletion.</returns>
        private bool IsDeletion(TextBox editor, string lastContent)
        {
            return editor.TextLength < lastContent.Length;
        }

        /// <summary>
        /// Gets the length of the text inserted or deleted.
        /// </summary>
        /// <param name="editor">The TextBox containing the result of the edit.</param>
        /// <param name="lastContent">The string representing the text prior to the edit.</param>
        /// <returns>The length of the edit.</returns>
        private int GetEditLength(TextBox editor, string lastContent)
        {
            return Math.Abs(editor.TextLength - lastContent.Length);
        }

        /// <summary>
        /// Gets the location of the beginning of the edit.
        /// </summary>
        /// <param name="editor">The TextBox containing the result of the edit.</param>
        /// <param name="isDeletion">Indicates whether the edit was a deletion.</param>
        /// <param name="len">The length of the edit string.</param>
        /// <returns>The location of the beginning of the edit.</returns>
        private int GetEditLocation(TextBox editor, bool isDeletion, int len)
        {
            if (isDeletion)
            {
                return editor.SelectionStart;
            }
            else
            {
                return editor.SelectionStart - len;
            }
        }

        /// <summary>
        /// Gets the edit string.
        /// </summary>
        /// <param name="content">The current content of the TextBox.</param>
        /// <param name="lastContent">The string representing the text prior to the edit.</param>
        /// <param name="isDeletion">Indicates whether the edit was a deletion.</param>
        /// <param name="editLocation">The location of the beginning of the edit.</param>
        /// <param name="len">The length of the edit.</param>
        /// <returns>The edit string.</returns>
        private string GetEditString(string content, string lastContent, bool isDeletion, int editLocation, int len)
        {
            if (isDeletion)
            {
                return lastContent.Substring(editLocation, len);
            }
            else
            {
                return content.Substring(editLocation, len);
            }
        }

        /// <summary>
        /// Performs the given edit on the contents of the given TextBox.
        /// </summary>
        /// <param name="editor">The TextBox to edit.</param>
        /// <param name="isDeletion">Indicates whether the edit is a deletion.</param>
        /// <param name="loc">The location of the beginning of the edit.</param>
        /// <param name="text">The text to insert or delete.</param>
        private void DoEdit(TextBox editor, bool isDeletion, int loc, string text)
        {
            if (isDeletion)
            {
                _lastText = editor.Text.Remove(loc, text.Length);
                editor.Text = _lastText;
                editor.SelectionStart = loc;
            }
            else
            {
                _lastText = editor.Text.Insert(loc, text);
                editor.Text = _lastText;
                editor.SelectionStart = loc + text.Length;
            }
        }

        /// <summary>
        /// Handles a TextChanged event on the edit buffer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEditBuffer_TextChanged(object sender, EventArgs e)
        {
            if (uxEditBuffer.Modified)
            {
                RecordEdit();
            }
        }

        /// <summary>
        /// Handles a Click event on the Undo menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxUndo_Click(object sender, EventArgs e)
        {
            string editStr = (string)_editHistory.Pop();
            int loc = (int)_editHistory.Pop();
            bool isDel = (bool)_editHistory.Pop();
            _undoHistory.Push(isDel);
            _undoHistory.Push(loc);
            _undoHistory.Push(editStr);
            DoEdit(uxEditBuffer, !isDel, loc, editStr);
            uxRedo.Enabled = true;
            uxUndo.Enabled = _editHistory.Count > 0;
        }

        /// <summary>
        /// Handles a Click event on the Redo menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRedo_Click(object sender, EventArgs e)
        {
            string editStr = (string)_undoHistory.Pop();
            int loc = (int)_undoHistory.Pop();
            bool isDel = (bool)_undoHistory.Pop();
            _editHistory.Push(isDel);
            _editHistory.Push(loc);
            _editHistory.Push(editStr);
            DoEdit(uxEditBuffer, isDel, loc, editStr);
            uxUndo.Enabled = true;
            uxRedo.Enabled = _undoHistory.Count > 0;
        }
    }
}
