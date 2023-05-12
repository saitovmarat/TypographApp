
namespace Typograph
{
    partial class MainForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBoxPanel = new System.Windows.Forms.Panel();
            this.typoLabel = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Label();
            this.textBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(472, 279);
            this.textBox.TabIndex = 0;
            // 
            // textBoxPanel
            // 
            this.textBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPanel.Controls.Add(this.textBox);
            this.textBoxPanel.Location = new System.Drawing.Point(167, 69);
            this.textBoxPanel.Name = "textBoxPanel";
            this.textBoxPanel.Size = new System.Drawing.Size(474, 281);
            this.textBoxPanel.TabIndex = 1;
            // 
            // typoLabel
            // 
            this.typoLabel.AutoSize = true;
            this.typoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typoLabel.Location = new System.Drawing.Point(331, 21);
            this.typoLabel.Name = "typoLabel";
            this.typoLabel.Size = new System.Drawing.Size(137, 29);
            this.typoLabel.TabIndex = 2;
            this.typoLabel.Text = "Типограф";
            // 
            // Button
            // 
            this.Button.AutoSize = true;
            this.Button.BackColor = System.Drawing.SystemColors.Control;
            this.Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button.Location = new System.Drawing.Point(290, 378);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(236, 34);
            this.Button.TabIndex = 3;
            this.Button.Text = "Оттипографить";
            this.Button.Click += new System.EventHandler(this.Button_Click);
            this.Button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.typoLabel);
            this.Controls.Add(this.textBoxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.textBoxPanel.ResumeLayout(false);
            this.textBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel textBoxPanel;
        private System.Windows.Forms.Label typoLabel;
        private System.Windows.Forms.Label Button;
    }
}

