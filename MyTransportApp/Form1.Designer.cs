
namespace MyTransportApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AbfahrtsdatumEingabe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Verbindungen = new System.Windows.Forms.Button();
            this.btn_Abfahrtstafel = new System.Windows.Forms.Button();
            this.btn_switch = new System.Windows.Forms.Button();
            this.dataGridView_Verbindungen = new System.Windows.Forms.DataGridView();
            this.startstationInput = new System.Windows.Forms.TextBox();
            this.endstationInput = new System.Windows.Forms.TextBox();
            this.zeitinput = new System.Windows.Forms.TextBox();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reisezeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Verbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bis";
            // 
            // AbfahrtsdatumEingabe
            // 
            this.AbfahrtsdatumEingabe.Location = new System.Drawing.Point(290, 87);
            this.AbfahrtsdatumEingabe.Name = "AbfahrtsdatumEingabe";
            this.AbfahrtsdatumEingabe.Size = new System.Drawing.Size(255, 22);
            this.AbfahrtsdatumEingabe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zeit";
            // 
            // btn_Verbindungen
            // 
            this.btn_Verbindungen.Location = new System.Drawing.Point(399, 134);
            this.btn_Verbindungen.Name = "btn_Verbindungen";
            this.btn_Verbindungen.Size = new System.Drawing.Size(146, 23);
            this.btn_Verbindungen.TabIndex = 11;
            this.btn_Verbindungen.Text = "Suchen";
            this.btn_Verbindungen.UseVisualStyleBackColor = true;
            this.btn_Verbindungen.Click += new System.EventHandler(this.btn_Verbindungen_Click);
            // 
            // btn_Abfahrtstafel
            // 
            this.btn_Abfahrtstafel.Location = new System.Drawing.Point(290, 134);
            this.btn_Abfahrtstafel.Name = "btn_Abfahrtstafel";
            this.btn_Abfahrtstafel.Size = new System.Drawing.Size(101, 23);
            this.btn_Abfahrtstafel.TabIndex = 12;
            this.btn_Abfahrtstafel.Text = "Abfahrtstafel";
            this.btn_Abfahrtstafel.UseVisualStyleBackColor = true;
            this.btn_Abfahrtstafel.Click += new System.EventHandler(this.btn_Abfahrtstafel_Click);
            // 
            // btn_switch
            // 
            this.btn_switch.Location = new System.Drawing.Point(186, 30);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(61, 23);
            this.btn_switch.TabIndex = 14;
            this.btn_switch.Text = "switch";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // dataGridView_Verbindungen
            // 
            this.dataGridView_Verbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Verbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Endstation,
            this.Reisezeit,
            this.Ankunft});
            this.dataGridView_Verbindungen.Location = new System.Drawing.Point(15, 175);
            this.dataGridView_Verbindungen.Name = "dataGridView_Verbindungen";
            this.dataGridView_Verbindungen.RowHeadersWidth = 51;
            this.dataGridView_Verbindungen.RowTemplate.Height = 24;
            this.dataGridView_Verbindungen.Size = new System.Drawing.Size(724, 381);
            this.dataGridView_Verbindungen.TabIndex = 15;
            // 
            // startstationInput
            // 
            this.startstationInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.startstationInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.startstationInput.Location = new System.Drawing.Point(12, 30);
            this.startstationInput.Name = "startstationInput";
            this.startstationInput.Size = new System.Drawing.Size(141, 22);
            this.startstationInput.TabIndex = 17;
            this.startstationInput.TextChanged += new System.EventHandler(this.startstationInput_TextChanged);
            this.startstationInput.Leave += new System.EventHandler(this.startstationInput_Leave);
            // 
            // endstationInput
            // 
            this.endstationInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.endstationInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.endstationInput.Location = new System.Drawing.Point(290, 31);
            this.endstationInput.Name = "endstationInput";
            this.endstationInput.Size = new System.Drawing.Size(141, 22);
            this.endstationInput.TabIndex = 18;
            this.endstationInput.TextChanged += new System.EventHandler(this.endstationInput_TextChanged);
            this.endstationInput.Leave += new System.EventHandler(this.endstationInput_Leave);
            // 
            // zeitinput
            // 
            this.zeitinput.Location = new System.Drawing.Point(124, 88);
            this.zeitinput.Name = "zeitinput";
            this.zeitinput.Size = new System.Drawing.Size(123, 22);
            this.zeitinput.TabIndex = 19;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 6;
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.Width = 125;
            // 
            // Endstation
            // 
            this.Endstation.HeaderText = "Richtung";
            this.Endstation.MinimumWidth = 6;
            this.Endstation.Name = "Endstation";
            this.Endstation.Width = 125;
            // 
            // Reisezeit
            // 
            this.Reisezeit.HeaderText = "Reisezeit";
            this.Reisezeit.MinimumWidth = 6;
            this.Reisezeit.Name = "Reisezeit";
            this.Reisezeit.Width = 125;
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.MinimumWidth = 6;
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 568);
            this.Controls.Add(this.zeitinput);
            this.Controls.Add(this.endstationInput);
            this.Controls.Add(this.startstationInput);
            this.Controls.Add(this.AbfahrtsdatumEingabe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_Verbindungen);
            this.Controls.Add(this.btn_switch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Abfahrtstafel);
            this.Controls.Add(this.btn_Verbindungen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Verbindungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker AbfahrtsdatumEingabe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Verbindungen;
        private System.Windows.Forms.Button btn_Abfahrtstafel;
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.DataGridView dataGridView_Verbindungen;
        private System.Windows.Forms.TextBox startstationInput;
        private System.Windows.Forms.TextBox endstationInput;
        private System.Windows.Forms.TextBox zeitinput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reisezeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
    }
}

