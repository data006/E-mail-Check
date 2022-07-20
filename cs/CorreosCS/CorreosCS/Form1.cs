using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CorreosCS
{

	









	public partial class Form1 : Form
	{

		public bool arroba;

		public Form1()
		{
			InitializeComponent();
		}












		private void btnValidar_Click(object sender, EventArgs e)
		{

			if ((LikeOperator.LikeString(txtCorreo.Text, "[a-z]*@[!.]?*.[a-z][a-z][a-z].[a-z][a-z]", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "[a-z]*@[!.]?*.[a-z][a-z][a-z]", CompareMethod.Binary)) & !LikeOperator.LikeString(txtCorreo.Text, "*@*@*", CompareMethod.Binary) & !LikeOperator.LikeString(txtCorreo.Text, "*@*.*.*.*", CompareMethod.Binary) & !LikeOperator.LikeString(txtCorreo.Text, "*--*", CompareMethod.Binary) & !LikeOperator.LikeString(txtCorreo.Text, "*..*", CompareMethod.Binary))
			{
				if (LikeOperator.LikeString(txtCorreo.Text, "*[/]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[!]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[*]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[,]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[[]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[]]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, @"*[\]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[+]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[=]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[{]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[}]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[|]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[&]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[(]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[)]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[;]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[:]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[']*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[^]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[%]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[$]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[#]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[`]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[~]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[<]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[>]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[ ]*", CompareMethod.Binary) | LikeOperator.LikeString(txtCorreo.Text, "*[?]*", CompareMethod.Binary))
				{
					MessageBox.Show("Correo Invalido");
				}
				else
				{
					MessageBox.Show("Correo Valido");
				}
			}
			else
			{
				MessageBox.Show("Correo Invalido");
			}

		}





	}
}
