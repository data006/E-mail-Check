namespace CorreosCS
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnValidar = new System.Windows.Forms.Button();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnValidar
			// 
			this.btnValidar.Location = new System.Drawing.Point(96, 68);
			this.btnValidar.Name = "btnValidar";
			this.btnValidar.Size = new System.Drawing.Size(72, 35);
			this.btnValidar.TabIndex = 3;
			this.btnValidar.Text = "Validar";
			this.btnValidar.UseVisualStyleBackColor = true;
			this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(54, 32);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(179, 20);
			this.txtCorreo.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lime;
			this.ClientSize = new System.Drawing.Size(283, 133);
			this.Controls.Add(this.btnValidar);
			this.Controls.Add(this.txtCorreo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnValidar;
		internal System.Windows.Forms.TextBox txtCorreo;
	}
}

