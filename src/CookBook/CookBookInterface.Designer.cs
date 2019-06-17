namespace CookBook
{
    partial class CookBookInterface
    {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateRecipeButton = new System.Windows.Forms.Button();
            this.allRecipeList = new System.Windows.Forms.ListView();
            this.SearchRecipe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CookBook";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Recipes";
            // 
            // updateRecipeButton
            // 
            this.updateRecipeButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecipeButton.Location = new System.Drawing.Point(449, 209);
            this.updateRecipeButton.Name = "updateRecipeButton";
            this.updateRecipeButton.Size = new System.Drawing.Size(127, 41);
            this.updateRecipeButton.TabIndex = 3;
            this.updateRecipeButton.Text = "Update";
            this.updateRecipeButton.UseVisualStyleBackColor = true;
            // 
            // allRecipeList
            // 
            this.allRecipeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allRecipeList.FullRowSelect = true;
            this.allRecipeList.GridLines = true;
            this.allRecipeList.Location = new System.Drawing.Point(36, 113);
            this.allRecipeList.MultiSelect = false;
            this.allRecipeList.Name = "allRecipeList";
            this.allRecipeList.Size = new System.Drawing.Size(407, 319);
            this.allRecipeList.TabIndex = 9;
            this.allRecipeList.UseCompatibleStateImageBehavior = false;
            this.allRecipeList.View = System.Windows.Forms.View.Details;
            // 
            // SearchRecipe
            // 
            this.SearchRecipe.Location = new System.Drawing.Point(102, 82);
            this.SearchRecipe.Name = "SearchRecipe";
            this.SearchRecipe.Size = new System.Drawing.Size(215, 20);
            this.SearchRecipe.TabIndex = 12;
            this.SearchRecipe.TextChanged += new System.EventHandler(this.SearchRecipe_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search";
            // 
            // CookBookInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchRecipe);
            this.Controls.Add(this.allRecipeList);
            this.Controls.Add(this.updateRecipeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CookBookInterface";
            this.Text = "CookBook Interface";
            this.Load += new System.EventHandler(this.CookBookInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateRecipeButton;
        private System.Windows.Forms.ListView allRecipeList;
        private System.Windows.Forms.TextBox SearchRecipe;
        private System.Windows.Forms.Label label3;
    }
}

