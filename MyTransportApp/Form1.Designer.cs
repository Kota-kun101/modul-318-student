
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AbfahrtsdatumEingabe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Verbindungen = new System.Windows.Forms.Button();
            this.btn_Abfahrtstafel = new System.Windows.Forms.Button();
            this.btn_switch = new System.Windows.Forms.Button();
            this.dataGridView_Verbindungen = new System.Windows.Forms.DataGridView();
            this.zeitinput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_Abfahrtstafel = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStationCombobox = new System.Windows.Forms.ComboBox();
            this.EndstationCombobox = new System.Windows.Forms.ComboBox();
            this.abfahrtInputCombobox = new System.Windows.Forms.ComboBox();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reisezeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Verbindungen)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Abfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bis";
            // 
            // AbfahrtsdatumEingabe
            // 
            this.AbfahrtsdatumEingabe.Location = new System.Drawing.Point(466, 88);
            this.AbfahrtsdatumEingabe.Name = "AbfahrtsdatumEingabe";
            this.AbfahrtsdatumEingabe.Size = new System.Drawing.Size(255, 22);
            this.AbfahrtsdatumEingabe.TabIndex = 4;
            this.AbfahrtsdatumEingabe.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zeit";
            // 
            // btn_Verbindungen
            // 
            this.btn_Verbindungen.Location = new System.Drawing.Point(574, 116);
            this.btn_Verbindungen.Name = "btn_Verbindungen";
            this.btn_Verbindungen.Size = new System.Drawing.Size(146, 23);
            this.btn_Verbindungen.TabIndex = 11;
            this.btn_Verbindungen.Text = "Suchen";
            this.btn_Verbindungen.UseVisualStyleBackColor = true;
            this.btn_Verbindungen.Click += new System.EventHandler(this.btn_Verbindungen_Click);
            // 
            // btn_Abfahrtstafel
            // 
            this.btn_Abfahrtstafel.Location = new System.Drawing.Point(289, 28);
            this.btn_Abfahrtstafel.Name = "btn_Abfahrtstafel";
            this.btn_Abfahrtstafel.Size = new System.Drawing.Size(101, 23);
            this.btn_Abfahrtstafel.TabIndex = 12;
            this.btn_Abfahrtstafel.Text = "Suchen";
            this.btn_Abfahrtstafel.UseVisualStyleBackColor = true;
            this.btn_Abfahrtstafel.Click += new System.EventHandler(this.btn_Abfahrtstafel_Click);
            // 
            // btn_switch
            // 
            this.btn_switch.Location = new System.Drawing.Point(124, 56);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(61, 23);
            this.btn_switch.TabIndex = 14;
            this.btn_switch.Text = "switch";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // dataGridView_Verbindungen
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Verbindungen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Verbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Verbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Endstation,
            this.Reisezeit,
            this.Ankunft});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Verbindungen.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Verbindungen.Location = new System.Drawing.Point(9, 205);
            this.dataGridView_Verbindungen.Name = "dataGridView_Verbindungen";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Verbindungen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Verbindungen.RowHeadersWidth = 51;
            this.dataGridView_Verbindungen.RowTemplate.Height = 24;
            this.dataGridView_Verbindungen.Size = new System.Drawing.Size(745, 318);
            this.dataGridView_Verbindungen.TabIndex = 15;
            this.dataGridView_Verbindungen.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Verbindungen_CellContentDoubleClick);
            // 
            // zeitinput
            // 
            this.zeitinput.Location = new System.Drawing.Point(466, 27);
            this.zeitinput.Name = "zeitinput";
            this.zeitinput.Size = new System.Drawing.Size(123, 22);
            this.zeitinput.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 562);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EndstationCombobox);
            this.tabPage1.Controls.Add(this.startStationCombobox);
            this.tabPage1.Controls.Add(this.dataGridView_Verbindungen);
            this.tabPage1.Controls.Add(this.zeitinput);
            this.tabPage1.Controls.Add(this.AbfahrtsdatumEingabe);
            this.tabPage1.Controls.Add(this.btn_Verbindungen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_switch);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.abfahrtInputCombobox);
            this.tabPage2.Controls.Add(this.dataGridView_Abfahrtstafel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_Abfahrtstafel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Abfahrtstafel
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Abfahrtstafel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Abfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Abfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Abfahrtstafel.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Abfahrtstafel.Location = new System.Drawing.Point(6, 73);
            this.dataGridView_Abfahrtstafel.Name = "dataGridView_Abfahrtstafel";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Abfahrtstafel.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Abfahrtstafel.RowHeadersWidth = 51;
            this.dataGridView_Abfahrtstafel.RowTemplate.Height = 24;
            this.dataGridView_Abfahrtstafel.Size = new System.Drawing.Size(750, 450);
            this.dataGridView_Abfahrtstafel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Station";
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Abfahrt";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Richtung";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // startStationCombobox
            // 
            this.startStationCombobox.FormattingEnabled = true;
            this.startStationCombobox.Location = new System.Drawing.Point(91, 26);
            this.startStationCombobox.Name = "startStationCombobox";
            this.startStationCombobox.Size = new System.Drawing.Size(154, 24);
            this.startStationCombobox.TabIndex = 20;
            this.startStationCombobox.TextChanged += new System.EventHandler(this.startStationCombobox_TextChanged);
            // 
            // EndstationCombobox
            // 
            this.EndstationCombobox.FormattingEnabled = true;
            this.EndstationCombobox.Location = new System.Drawing.Point(91, 90);
            this.EndstationCombobox.Name = "EndstationCombobox";
            this.EndstationCombobox.Size = new System.Drawing.Size(154, 24);
            this.EndstationCombobox.TabIndex = 21;
            this.EndstationCombobox.TextChanged += new System.EventHandler(this.EndstationCombobox_TextChanged);
            // 
            // abfahrtInputCombobox
            // 
            this.abfahrtInputCombobox.FormattingEnabled = true;
            this.abfahrtInputCombobox.Location = new System.Drawing.Point(98, 28);
            this.abfahrtInputCombobox.Name = "abfahrtInputCombobox";
            this.abfahrtInputCombobox.Size = new System.Drawing.Size(185, 24);
            this.abfahrtInputCombobox.TabIndex = 17;
            this.abfahrtInputCombobox.TextChanged += new System.EventHandler(this.abfahrtInputCombobox_TextChanged);
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
            this.AcceptButton = this.btn_Verbindungen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 560);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Verbindungen)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Abfahrtstafel)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox zeitinput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_Abfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox EndstationCombobox;
        private System.Windows.Forms.ComboBox startStationCombobox;
        private System.Windows.Forms.ComboBox abfahrtInputCombobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reisezeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
    }
}

