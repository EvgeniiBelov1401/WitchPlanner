namespace WitchPlanner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupAllInfoBox = new GroupBox();
            buttonRecord = new Button();
            groupClientNameBox = new GroupBox();
            textBoxClientName = new TextBox();
            clientBindingSource = new BindingSource(components);
            dataGridViewClients = new DataGridView();
            clientBindingSource1 = new BindingSource(components);
            groupAllInfoBox.SuspendLayout();
            groupClientNameBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupAllInfoBox
            // 
            groupAllInfoBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupAllInfoBox.AutoSize = true;
            groupAllInfoBox.BackColor = SystemColors.AppWorkspace;
            groupAllInfoBox.Controls.Add(buttonRecord);
            groupAllInfoBox.Controls.Add(groupClientNameBox);
            groupAllInfoBox.Font = new Font("Matura MT Script Capitals", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupAllInfoBox.Location = new Point(16, 16);
            groupAllInfoBox.Name = "groupAllInfoBox";
            groupAllInfoBox.Size = new Size(1451, 445);
            groupAllInfoBox.TabIndex = 0;
            groupAllInfoBox.TabStop = false;
            groupAllInfoBox.Text = "Информация ";
            // 
            // buttonRecord
            // 
            buttonRecord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRecord.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonRecord.Location = new Point(1128, 312);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(312, 96);
            buttonRecord.TabIndex = 1;
            buttonRecord.Text = "Записать";
            buttonRecord.UseVisualStyleBackColor = true;
            buttonRecord.Click += buttonRecord_Click;
            // 
            // groupClientNameBox
            // 
            groupClientNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupClientNameBox.Controls.Add(textBoxClientName);
            groupClientNameBox.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupClientNameBox.Location = new Point(272, 48);
            groupClientNameBox.Name = "groupClientNameBox";
            groupClientNameBox.Size = new Size(253, 229);
            groupClientNameBox.TabIndex = 0;
            groupClientNameBox.TabStop = false;
            groupClientNameBox.Text = "Имя";
            // 
            // textBoxClientName
            // 
            textBoxClientName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxClientName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBoxClientName.Location = new Point(16, 40);
            textBoxClientName.Name = "textBoxClientName";
            textBoxClientName.Size = new Size(221, 30);
            textBoxClientName.TabIndex = 0;
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Modules.Client);
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(16, 480);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(816, 188);
            dataGridViewClients.TabIndex = 1;
            // 
            // clientBindingSource1
            // 
            clientBindingSource1.DataSource = typeof(Modules.Client);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(dataGridViewClients);
            Controls.Add(groupAllInfoBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Планировщик ведьмы";
            groupAllInfoBox.ResumeLayout(false);
            groupClientNameBox.ResumeLayout(false);
            groupClientNameBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupAllInfoBox;
        private GroupBox groupClientNameBox;
        private TextBox textBoxClientName;
        private Button buttonRecord;
        private BindingSource clientBindingSource;
        private DataGridView dataGridViewClients;
        private BindingSource clientBindingSource1;
    }
}
