namespace SII_lr3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.oilPriceComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.showRulesButton = new System.Windows.Forms.Button();
            this.rulesListBox = new System.Windows.Forms.ListBox();
            this.hideRulesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена на нефть:";
            // 
            // oilPriceComboBox
            // 
            this.oilPriceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oilPriceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oilPriceComboBox.FormattingEnabled = true;
            this.oilPriceComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.oilPriceComboBox.Location = new System.Drawing.Point(147, 6);
            this.oilPriceComboBox.Name = "oilPriceComboBox";
            this.oilPriceComboBox.Size = new System.Drawing.Size(202, 28);
            this.oilPriceComboBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(236, 55);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(113, 29);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(48, 100);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(533, 26);
            this.ResultTextBox.TabIndex = 9;
            // 
            // showRulesButton
            // 
            this.showRulesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showRulesButton.Location = new System.Drawing.Point(230, 141);
            this.showRulesButton.Name = "showRulesButton";
            this.showRulesButton.Size = new System.Drawing.Size(124, 28);
            this.showRulesButton.TabIndex = 10;
            this.showRulesButton.Text = "Показать правила";
            this.showRulesButton.UseVisualStyleBackColor = true;
            this.showRulesButton.Click += new System.EventHandler(this.showRulesButton_Click);
            // 
            // rulesListBox
            // 
            this.rulesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesListBox.FormattingEnabled = true;
            this.rulesListBox.ItemHeight = 16;
            this.rulesListBox.Location = new System.Drawing.Point(22, 213);
            this.rulesListBox.Name = "rulesListBox";
            this.rulesListBox.Size = new System.Drawing.Size(559, 292);
            this.rulesListBox.TabIndex = 11;
            this.rulesListBox.Visible = false;
            // 
            // hideRulesButton
            // 
            this.hideRulesButton.Location = new System.Drawing.Point(219, 525);
            this.hideRulesButton.Name = "hideRulesButton";
            this.hideRulesButton.Size = new System.Drawing.Size(109, 23);
            this.hideRulesButton.TabIndex = 12;
            this.hideRulesButton.Text = "Спрятать правила";
            this.hideRulesButton.UseVisualStyleBackColor = true;
            this.hideRulesButton.Visible = false;
            this.hideRulesButton.Click += new System.EventHandler(this.hideRulesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сбалансированность бюджета:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "B\'=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 192);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hideRulesButton);
            this.Controls.Add(this.rulesListBox);
            this.Controls.Add(this.showRulesButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.oilPriceComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Алгоритм Мамдани: бюджет Саудовской Аравии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox oilPriceComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button showRulesButton;
        private System.Windows.Forms.ListBox rulesListBox;
        private System.Windows.Forms.Button hideRulesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

