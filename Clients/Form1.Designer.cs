namespace Clients
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clientsGridView = new System.Windows.Forms.DataGridView();
            this.clientsBS = new System.Windows.Forms.BindingSource(this.components);
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ageMinText = new System.Windows.Forms.TextBox();
            this.ageMaxText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.avgAgeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBS)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsGridView
            // 
            this.clientsGridView.AllowUserToAddRows = false;
            this.clientsGridView.AllowUserToDeleteRows = false;
            this.clientsGridView.AutoGenerateColumns = false;
            this.clientsGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fio,
            this.date});
            this.clientsGridView.DataSource = this.clientsBS;
            this.clientsGridView.Location = new System.Drawing.Point(40, 30);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.ReadOnly = true;
            this.clientsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsGridView.Size = new System.Drawing.Size(402, 322);
            this.clientsGridView.TabIndex = 0;
            // 
            // fio
            // 
            this.fio.DataPropertyName = "_Fio";
            this.fio.Frozen = true;
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            this.fio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fio.Width = 200;
            // 
            // date
            // 
            this.date.DataPropertyName = "_Pension";
            this.date.Frozen = true;
            this.date.HeaderText = "Года до пенсии";
            this.date.Name = "date";
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Минимальный возраст:";
            // 
            // ageMinText
            // 
            this.ageMinText.Location = new System.Drawing.Point(479, 46);
            this.ageMinText.Name = "ageMinText";
            this.ageMinText.ReadOnly = true;
            this.ageMinText.Size = new System.Drawing.Size(135, 20);
            this.ageMinText.TabIndex = 2;
            // 
            // ageMaxText
            // 
            this.ageMaxText.Location = new System.Drawing.Point(479, 98);
            this.ageMaxText.Name = "ageMaxText";
            this.ageMaxText.ReadOnly = true;
            this.ageMaxText.Size = new System.Drawing.Size(135, 20);
            this.ageMaxText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Максимальный возраст:";
            // 
            // avgAgeText
            // 
            this.avgAgeText.Location = new System.Drawing.Point(479, 151);
            this.avgAgeText.Name = "avgAgeText";
            this.avgAgeText.ReadOnly = true;
            this.avgAgeText.Size = new System.Drawing.Size(135, 20);
            this.avgAgeText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Средний возраст:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 398);
            this.Controls.Add(this.avgAgeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageMaxText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageMinText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientsGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsGridView;
        private System.Windows.Forms.BindingSource clientsBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageMinText;
        private System.Windows.Forms.TextBox ageMaxText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox avgAgeText;
        private System.Windows.Forms.Label label3;
    }
}

