namespace RecipeBookApplication
{
    partial class RecipeForm
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
            this.recipeLabel = new System.Windows.Forms.Label();
            this.recipeListBox = new System.Windows.Forms.ListBox();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.recipeDifficultyTextBox = new System.Windows.Forms.TextBox();
            this.recipeDifficultyLabel = new System.Windows.Forms.Label();
            this.recipeDirectionsLabel = new System.Windows.Forms.Label();
            this.DirectionsTextBox = new System.Windows.Forms.RichTextBox();
            this.recipeSubmitButton = new System.Windows.Forms.Button();
            this.addIngredientTextBox = new System.Windows.Forms.TextBox();
            this.addIngredientLabel = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.outDirectionsTextBox = new System.Windows.Forms.RichTextBox();
            this.outDirectionsLabel = new System.Windows.Forms.Label();
            this.shoppingListGroupBox = new System.Windows.Forms.GroupBox();
            this.AddShoppingListButton = new System.Windows.Forms.Button();
            this.shoppingDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.shoppingListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Location = new System.Drawing.Point(13, 13);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(46, 13);
            this.recipeLabel.TabIndex = 0;
            this.recipeLabel.Text = "Recipes";
            // 
            // recipeListBox
            // 
            this.recipeListBox.FormattingEnabled = true;
            this.recipeListBox.Location = new System.Drawing.Point(12, 29);
            this.recipeListBox.Name = "recipeListBox";
            this.recipeListBox.Size = new System.Drawing.Size(120, 95);
            this.recipeListBox.TabIndex = 1;
            this.recipeListBox.SelectedIndexChanged += new System.EventHandler(this.recipeListBox_SelectedIndexChanged);
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.Location = new System.Drawing.Point(12, 173);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(120, 95);
            this.ingredientsListBox.TabIndex = 3;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(13, 157);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(59, 13);
            this.ingredientsLabel.TabIndex = 2;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Location = new System.Drawing.Point(6, 25);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(72, 13);
            this.recipeNameLabel.TabIndex = 4;
            this.recipeNameLabel.Text = "Recipe Name";
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.Location = new System.Drawing.Point(9, 41);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.recipeNameTextBox.TabIndex = 5;
            // 
            // recipeDifficultyTextBox
            // 
            this.recipeDifficultyTextBox.Location = new System.Drawing.Point(9, 80);
            this.recipeDifficultyTextBox.Name = "recipeDifficultyTextBox";
            this.recipeDifficultyTextBox.Size = new System.Drawing.Size(185, 20);
            this.recipeDifficultyTextBox.TabIndex = 7;
            // 
            // recipeDifficultyLabel
            // 
            this.recipeDifficultyLabel.AutoSize = true;
            this.recipeDifficultyLabel.Location = new System.Drawing.Point(6, 64);
            this.recipeDifficultyLabel.Name = "recipeDifficultyLabel";
            this.recipeDifficultyLabel.Size = new System.Drawing.Size(84, 13);
            this.recipeDifficultyLabel.TabIndex = 6;
            this.recipeDifficultyLabel.Text = "Recipe Difficulty";
            // 
            // recipeDirectionsLabel
            // 
            this.recipeDirectionsLabel.AutoSize = true;
            this.recipeDirectionsLabel.Location = new System.Drawing.Point(6, 106);
            this.recipeDirectionsLabel.Name = "recipeDirectionsLabel";
            this.recipeDirectionsLabel.Size = new System.Drawing.Size(91, 13);
            this.recipeDirectionsLabel.TabIndex = 8;
            this.recipeDirectionsLabel.Text = "Recipe Directions";
            this.recipeDirectionsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DirectionsTextBox
            // 
            this.DirectionsTextBox.Location = new System.Drawing.Point(9, 122);
            this.DirectionsTextBox.Name = "DirectionsTextBox";
            this.DirectionsTextBox.Size = new System.Drawing.Size(185, 228);
            this.DirectionsTextBox.TabIndex = 10;
            this.DirectionsTextBox.Text = "";
            // 
            // recipeSubmitButton
            // 
            this.recipeSubmitButton.Location = new System.Drawing.Point(40, 356);
            this.recipeSubmitButton.Name = "recipeSubmitButton";
            this.recipeSubmitButton.Size = new System.Drawing.Size(88, 22);
            this.recipeSubmitButton.TabIndex = 11;
            this.recipeSubmitButton.Text = "Submit";
            this.recipeSubmitButton.UseVisualStyleBackColor = true;
            this.recipeSubmitButton.Click += new System.EventHandler(this.recipeSubmitButton_Click);
            // 
            // addIngredientTextBox
            // 
            this.addIngredientTextBox.Location = new System.Drawing.Point(6, 36);
            this.addIngredientTextBox.Name = "addIngredientTextBox";
            this.addIngredientTextBox.Size = new System.Drawing.Size(100, 20);
            this.addIngredientTextBox.TabIndex = 12;
            // 
            // addIngredientLabel
            // 
            this.addIngredientLabel.AutoSize = true;
            this.addIngredientLabel.Location = new System.Drawing.Point(7, 20);
            this.addIngredientLabel.Name = "addIngredientLabel";
            this.addIngredientLabel.Size = new System.Drawing.Size(54, 13);
            this.addIngredientLabel.TabIndex = 13;
            this.addIngredientLabel.Text = "Ingredient";
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Location = new System.Drawing.Point(10, 112);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(75, 23);
            this.addIngredientButton.TabIndex = 14;
            this.addIngredientButton.Text = "Add";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.amountLabel);
            this.groupBox1.Controls.Add(this.addIngredientTextBox);
            this.groupBox1.Controls.Add(this.addIngredientButton);
            this.groupBox1.Controls.Add(this.addIngredientLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 158);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Ingredients";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recipeNameLabel);
            this.groupBox2.Controls.Add(this.recipeNameTextBox);
            this.groupBox2.Controls.Add(this.recipeSubmitButton);
            this.groupBox2.Controls.Add(this.recipeDifficultyLabel);
            this.groupBox2.Controls.Add(this.DirectionsTextBox);
            this.groupBox2.Controls.Add(this.recipeDifficultyTextBox);
            this.groupBox2.Controls.Add(this.recipeDirectionsLabel);
            this.groupBox2.Location = new System.Drawing.Point(485, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 401);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Recipe";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(6, 75);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 15;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(7, 59);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(76, 13);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "Amount (Fl Oz)";
            // 
            // outDirectionsTextBox
            // 
            this.outDirectionsTextBox.Location = new System.Drawing.Point(158, 28);
            this.outDirectionsTextBox.Name = "outDirectionsTextBox";
            this.outDirectionsTextBox.ReadOnly = true;
            this.outDirectionsTextBox.Size = new System.Drawing.Size(274, 222);
            this.outDirectionsTextBox.TabIndex = 16;
            this.outDirectionsTextBox.Text = "";
            // 
            // outDirectionsLabel
            // 
            this.outDirectionsLabel.AutoSize = true;
            this.outDirectionsLabel.Location = new System.Drawing.Point(165, 12);
            this.outDirectionsLabel.Name = "outDirectionsLabel";
            this.outDirectionsLabel.Size = new System.Drawing.Size(54, 13);
            this.outDirectionsLabel.TabIndex = 17;
            this.outDirectionsLabel.Text = "Directions";
            // 
            // shoppingListGroupBox
            // 
            this.shoppingListGroupBox.Controls.Add(this.shoppingDataGrid);
            this.shoppingListGroupBox.Location = new System.Drawing.Point(158, 263);
            this.shoppingListGroupBox.Name = "shoppingListGroupBox";
            this.shoppingListGroupBox.Size = new System.Drawing.Size(274, 190);
            this.shoppingListGroupBox.TabIndex = 18;
            this.shoppingListGroupBox.TabStop = false;
            this.shoppingListGroupBox.Text = "Shopping List";
            // 
            // AddShoppingListButton
            // 
            this.AddShoppingListButton.Location = new System.Drawing.Point(12, 130);
            this.AddShoppingListButton.Name = "AddShoppingListButton";
            this.AddShoppingListButton.Size = new System.Drawing.Size(120, 23);
            this.AddShoppingListButton.TabIndex = 19;
            this.AddShoppingListButton.Text = "Add To Shopping List";
            this.AddShoppingListButton.UseVisualStyleBackColor = true;
            this.AddShoppingListButton.Click += new System.EventHandler(this.AddShoppingListButton_Click);
            // 
            // shoppingDataGrid
            // 
            this.shoppingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingDataGrid.Location = new System.Drawing.Point(3, 16);
            this.shoppingDataGrid.Name = "shoppingDataGrid";
            this.shoppingDataGrid.Size = new System.Drawing.Size(237, 150);
            this.shoppingDataGrid.TabIndex = 0;
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 509);
            this.Controls.Add(this.AddShoppingListButton);
            this.Controls.Add(this.shoppingListGroupBox);
            this.Controls.Add(this.outDirectionsLabel);
            this.Controls.Add(this.outDirectionsTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.recipeListBox);
            this.Controls.Add(this.recipeLabel);
            this.Name = "RecipeForm";
            this.Text = "Recipe Book";
            this.Load += new System.EventHandler(this.RecipeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.shoppingListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipeLabel;
        private System.Windows.Forms.ListBox recipeListBox;
        private System.Windows.Forms.ListBox ingredientsListBox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.TextBox recipeDifficultyTextBox;
        private System.Windows.Forms.Label recipeDifficultyLabel;
        private System.Windows.Forms.Label recipeDirectionsLabel;
        private System.Windows.Forms.RichTextBox DirectionsTextBox;
        private System.Windows.Forms.Button recipeSubmitButton;
        private System.Windows.Forms.TextBox addIngredientTextBox;
        private System.Windows.Forms.Label addIngredientLabel;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox outDirectionsTextBox;
        private System.Windows.Forms.Label outDirectionsLabel;
        private System.Windows.Forms.GroupBox shoppingListGroupBox;
        private System.Windows.Forms.Button AddShoppingListButton;
        private System.Windows.Forms.DataGridView shoppingDataGrid;
    }
}

