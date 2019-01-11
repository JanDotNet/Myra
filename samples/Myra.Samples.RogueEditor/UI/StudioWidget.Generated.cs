/* Generated by Myra UI Editor at 12.01.2019 3:36:24 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.Samples.RogueEditor.UI
{
	partial class StudioWidget
	{
		private void BuildUI()
		{
			_menuFileNew = new MenuItem();
			_menuFileNew.Id = "_menuFileNew";
			_menuFileNew.Text = "&New";

			_menuFileOpen = new MenuItem();
			_menuFileOpen.Id = "_menuFileOpen";
			_menuFileOpen.Text = "&Open";

			_menuFileSave = new MenuItem();
			_menuFileSave.Id = "_menuFileSave";
			_menuFileSave.Text = "&Save";

			var menuSeparator1 = new MenuSeparator();

			_menuFileDebugOptions = new MenuItem();
			_menuFileDebugOptions.Id = "_menuFileDebugOptions";
			_menuFileDebugOptions.Text = "&UI Debug Options";

			var menuSeparator2 = new MenuSeparator();

			_quitMenuItem = new MenuItem();
			_quitMenuItem.Id = "_quitMenuItem";
			_quitMenuItem.Text = "&Quit";

			var menuItem1 = new MenuItem();
			menuItem1.Id = "";
			menuItem1.Text = "&File";
			menuItem1.Items.Add(_menuFileNew);
			menuItem1.Items.Add(_menuFileOpen);
			menuItem1.Items.Add(_menuFileSave);
			menuItem1.Items.Add(menuSeparator1);
			menuItem1.Items.Add(_menuFileDebugOptions);
			menuItem1.Items.Add(menuSeparator2);
			menuItem1.Items.Add(_quitMenuItem);

			_menuControlsAddTileInfo = new MenuItem();
			_menuControlsAddTileInfo.Id = "_menuControlsAddTileInfo";
			_menuControlsAddTileInfo.Text = "Add &Tile Info";

			_menuControlsAddCreatureInfo = new MenuItem();
			_menuControlsAddCreatureInfo.Id = "_menuControlsAddCreatureInfo";
			_menuControlsAddCreatureInfo.Text = "Add &Creature Info";

			_menuControlsAddMap = new MenuItem();
			_menuControlsAddMap.Id = "_menuControlsAddMap";
			_menuControlsAddMap.Text = "Add &Map";

			_menuItems = new MenuItem();
			_menuItems.Id = "_menuItems";
			_menuItems.Text = "&Items";
			_menuItems.Items.Add(_menuControlsAddTileInfo);
			_menuItems.Items.Add(_menuControlsAddCreatureInfo);
			_menuItems.Items.Add(_menuControlsAddMap);

			_aboutMenuItem = new MenuItem();
			_aboutMenuItem.Id = "_aboutMenuItem";
			_aboutMenuItem.Text = "&About";

			var menuItem2 = new MenuItem();
			menuItem2.Id = "";
			menuItem2.Text = "&Help";
			menuItem2.Items.Add(_aboutMenuItem);

			_mainMenu = new HorizontalMenu();
			_mainMenu.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_mainMenu.Id = "_mainMenu";
			_mainMenu.CanFocus = true;
			_mainMenu.Items.Add(menuItem1);
			_mainMenu.Items.Add(_menuItems);
			_mainMenu.Items.Add(menuItem2);

			_leftContainer = new Panel();
			_leftContainer.Id = "_leftContainer";

			_mapViewerContainer = new Panel();
			_mapViewerContainer.Id = "_mapViewerContainer";

			_rightSplitPane = new VerticalSplitPane();
			_rightSplitPane.Id = "_rightSplitPane";
			_rightSplitPane.GridColumn = 2;
			_rightSplitPane.GridRow = 1;
			_rightSplitPane.Widgets.Add(_mapViewerContainer);

			_topSplitPane = new HorizontalSplitPane();
			_topSplitPane.Id = "_topSplitPane";
			_topSplitPane.GridRow = 1;
			_topSplitPane.Widgets.Add(_leftContainer);
			_topSplitPane.Widgets.Add(_rightSplitPane);

			
			RowsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			Id = "Root";
			Widgets.Add(_mainMenu);
			Widgets.Add(_topSplitPane);
		}

		
		public MenuItem _menuFileNew;
		public MenuItem _menuFileOpen;
		public MenuItem _menuFileSave;
		public MenuItem _menuFileDebugOptions;
		public MenuItem _quitMenuItem;
		public MenuItem _menuControlsAddTileInfo;
		public MenuItem _menuControlsAddCreatureInfo;
		public MenuItem _menuControlsAddMap;
		public MenuItem _menuItems;
		public MenuItem _aboutMenuItem;
		public HorizontalMenu _mainMenu;
		public Panel _leftContainer;
		public Panel _mapViewerContainer;
		public VerticalSplitPane _rightSplitPane;
		public HorizontalSplitPane _topSplitPane;
	}
}