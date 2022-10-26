using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidmerFractionMath
{
    public partial class frmMain : Form
    {
        MixedFraction f1, f2;

        Fraction answer;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetInput();

            // The Java way...
            //answer = new Fraction();
            //answer.Add(f1, f2);

            // the improved C# way using operator overlaod
            answer = f1 + f2;

            // Convert an improper fraction to a mized fraction
            MixedFraction manswer = new MixedFraction();
            manswer.ToMixedFraction(answer);

            txtWholeResult.Text = Convert.ToString(manswer.GetmWhole());

            txtNumeratorResult.Text = Convert.ToString(manswer.GetmNumerator());
            txtDenominatorResult.Text = Convert.ToString(manswer.GetmDenominator());
            lblResult.Text = manswer.GetString();

        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            GetInput();

            // The Java way...
            //answer = new Fraction();
            //answer.Add(f1, f2);

            // the improved C# way using operator overlaod
            answer = f1 - f2;

            // Convert an improper fraction to a mized fraction
            MixedFraction manswer = new MixedFraction();
            manswer.ToMixedFraction(answer);

            txtWholeResult.Text = Convert.ToString(manswer.GetmWhole());

            txtNumeratorResult.Text = Convert.ToString(manswer.GetmNumerator());
            txtDenominatorResult.Text = Convert.ToString(manswer.GetmDenominator());
            lblResult.Text = manswer.GetString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GetInput();

            // The Java way...
            //answer = new Fraction();
            //answer.Add(f1, f2);

            // the improved C# way using operator overlaod
            answer = f1 * f2;

            // Convert an improper fraction to a mized fraction
            MixedFraction manswer = new MixedFraction();
            manswer.ToMixedFraction(answer);

            txtWholeResult.Text = Convert.ToString(manswer.GetmWhole());

            txtNumeratorResult.Text = Convert.ToString(manswer.GetmNumerator());
            txtDenominatorResult.Text = Convert.ToString(manswer.GetmDenominator());
            lblResult.Text = manswer.GetString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            GetInput();

            // The Java way...
            //answer = new Fraction();
            //answer.Add(f1, f2);

            // the improved C# way using operator overlaod
            answer = f1 / f2;

            // Convert an improper fraction to a mized fraction
            MixedFraction manswer = new MixedFraction();
            manswer.ToMixedFraction(answer);

            txtWholeResult.Text = Convert.ToString(manswer.GetmWhole());

            txtNumeratorResult.Text = Convert.ToString(manswer.GetmNumerator());
            txtDenominatorResult.Text = Convert.ToString(manswer.GetmDenominator());
            lblResult.Text = manswer.GetString();
        }
        private void GetInput()
        {
            int w1, n1, d1, w2, n2, d2;

            w1 = Convert.ToInt32(txtWhole1.Text);
            n1 = Convert.ToInt32(txtNumerator1.Text);
            d1 = Convert.ToInt32(txtDenominator1.Text);

            // Instantiation is happening with the 'new' keyword
            f1 = new MixedFraction(w1, n1, d1);

            w2 = Convert.ToInt32(txtWhole2.Text);
            n2 = Convert.ToInt32(txtNumerator2.Text);
            d2 = Convert.ToInt32(txtDenominator2.Text);

            // Instantiation is happening with the 'new' keyword
            f2 = new MixedFraction(w2, n2, d2);

            Console.WriteLine("f1 whole = " + f1.GetmWhole());
            Console.WriteLine("f1 numerator = " + f1.GetNumerator());
            Console.WriteLine("f1 denominator = " + f1.GetDenominator());

            Console.WriteLine("f2 whole = " + f2.GetmWhole());
            Console.WriteLine("f2 numerator = " + f2.GetNumerator());
            Console.WriteLine("f2 denominator = " + f2.GetDenominator());
            Console.WriteLine();
        }
    }
}
