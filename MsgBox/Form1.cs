namespace MsgBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender,EventArgs e)
		{

			string m1 =
@"
Ahi serva Italia,
di dolore ostello,
nave sanza nocchiere in gran tempesta,
non donna di province, ma bordello!
";

			string m2 =
@"
Dir� d�Orlando in un medesmo tratto/cosa non detta in prosa mai n� in rima:
che per amor venne in furore e matto,/d�uom che s� saggio era stimato prima;
se da colei che tal quasi m�ha fatto,/che �l poco ingegno ad or ad or mi lima,
me ne sar� per� tanto concesso,/che mi basti a finir quanto ho promesso.
";

			//m2 = m2.Replace("/",Environment.NewLine);
			string m = string.Empty;
			m += m1;
			m += m2;

			MessageBox.Show(m);
			DialogResult res = MsgBox.Show(m,"cap",MessageBoxButtons.YesNoCancel);
			MessageBox.Show(res.ToString());
		}
	}
}
