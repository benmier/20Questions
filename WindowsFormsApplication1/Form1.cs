using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Question root;

        public Form1()
        {
            InitializeComponent();

            Question q1 = new Question();
            q1.question = "Is it organic?";
            q1.yes = new Question();
            q1.yes.question = "It is chocolate?";
            q1.no= new Question();
            q1.no.question = "It is sand?";
            root = q1;
            root.prev = null;
            questionText.Text = q1.question;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            //was this a leaf?
            //if yes, we guessed it
            //if no, move down the yes branch
            if (root.yes == null)
            {
                questionText.Text = "Yay got it!";
            }
            else
            {
                questionText.Text = root.yes.question;
                root.yes.prev = root;
                root = root.yes;
            }


        }

        private void noButton_Click(object sender, EventArgs e)
        {
            //if it was a leaf, we don't know it so get new info
            //if not a leaf, move down the no branch
            if(root.no == null)
            {
                questionText.Text = "I give up! Tell me!";
                QuestionBox.ReadOnly = false;
                SubmitBox.ReadOnly = false;
            }
            else
            {
                questionText.Text = root.no.question;
                root.no.prev = root;
                root = root.no;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            root.no = new Question();
            root.no.question = QuestionBox.Text;
            root.no.prev = root;
            root = root.no;
            root.yes = new Question();
            root.yes.question = SubmitBox.Text;
            while (root.prev != null) root = root.prev;
            questionText.Text = root.question;
            QuestionBox.Text = "";
            SubmitBox.Text = "";
            QuestionBox.ReadOnly = true;
            SubmitBox.ReadOnly = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
