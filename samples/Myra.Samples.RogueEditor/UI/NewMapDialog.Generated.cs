/* Generated by Myra UI Editor at 12.01.2019 2:52:14 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.Samples.RogueEditor.UI
{
	partial class NewMapDialog
	{
		private void BuildUI()
		{
			var textBlock1 = new TextBlock();
			textBlock1.Text = "Id:";
			textBlock1.Wrap = true;

			_textId = new TextField();
			_textId.Text = "";
			_textId.Wrap = true;
			_textId.FocusedTextColor = Color.TransparentBlack;
			_textId.ClipToBounds = false;
			_textId.Id = "_textId";
			_textId.GridColumn = 1;

			var textBlock2 = new TextBlock();
			textBlock2.Text = "Width:";
			textBlock2.Wrap = true;
			textBlock2.GridRow = 1;

			_spinWidth = new SpinButton();
			_spinWidth.Maximum = 1024;
			_spinWidth.Minimum = 1;
			_spinWidth.Value = 48;
			_spinWidth.Integer = true;
			_spinWidth.Id = "_spinWidth";
			_spinWidth.GridColumn = 1;
			_spinWidth.GridRow = 1;

			var textBlock3 = new TextBlock();
			textBlock3.Text = "Height:";
			textBlock3.Wrap = true;
			textBlock3.GridRow = 2;

			_spinHeight = new SpinButton();
			_spinHeight.Maximum = 1024;
			_spinHeight.Minimum = 1;
			_spinHeight.Value = 48;
			_spinHeight.Integer = true;
			_spinHeight.Id = "_spinHeight";
			_spinHeight.GridColumn = 1;
			_spinHeight.GridRow = 2;

			var textBlock4 = new TextBlock();
			textBlock4.Text = "Filler:";
			textBlock4.Wrap = true;
			textBlock4.GridRow = 3;

			_comboFiller = new ComboBox();
			_comboFiller.Id = "_comboFiller";
			_comboFiller.GridColumn = 1;
			_comboFiller.GridRow = 3;

			var grid1 = new Grid();
			grid1.ColumnSpacing = 8;
			grid1.RowSpacing = 8;
			grid1.ColumnsProportions.Add(new Grid.Proportion());
			grid1.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			grid1.RowsProportions.Add(new Grid.Proportion());
			grid1.RowsProportions.Add(new Grid.Proportion());
			grid1.RowsProportions.Add(new Grid.Proportion());
			grid1.RowsProportions.Add(new Grid.Proportion());
			grid1.Width = 400;
			grid1.Height = 100;
			grid1.GridRow = 1;
			grid1.Widgets.Add(textBlock1);
			grid1.Widgets.Add(_textId);
			grid1.Widgets.Add(textBlock2);
			grid1.Widgets.Add(_spinWidth);
			grid1.Widgets.Add(textBlock3);
			grid1.Widgets.Add(_spinHeight);
			grid1.Widgets.Add(textBlock4);
			grid1.Widgets.Add(_comboFiller);

			
			Title = "New Map";
			Left = 122;
			Top = 258;
			Content = grid1;
		}

		
		public TextField _textId;
		public SpinButton _spinWidth;
		public SpinButton _spinHeight;
		public ComboBox _comboFiller;
	}
}