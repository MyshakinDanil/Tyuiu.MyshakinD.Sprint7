namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    partial class FormInstruction {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruction));
            textBoxInstruction = new TextBox();
            SuspendLayout();
            // 
            // textBoxInstruction
            // 
            textBoxInstruction.Font = new Font("Segoe UI", 15F);
            textBoxInstruction.Location = new Point(12, 12);
            textBoxInstruction.Multiline = true;
            textBoxInstruction.Name = "textBoxInstruction";
            textBoxInstruction.ReadOnly = true;
            textBoxInstruction.Size = new Size(776, 426);
            textBoxInstruction.TabIndex = 0;
            textBoxInstruction.TabStop = false;
            textBoxInstruction.Text = resources.GetString("textBoxInstruction.Text");
            // 
            // FormInstruction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxInstruction);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInstruction";
            Text = "Инструкция";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInstruction;
    }
}