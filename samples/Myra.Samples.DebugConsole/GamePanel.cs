/* Generated by MyraPad at 14.12.2019 14:46:23 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;

namespace Myra.Samples.DebugConsole
{
	public partial class GamePanel
	{
		public GamePanel()
		{
			BuildUI();

			_buttonDebugPanel.Click += _buttonDebugPanel_Click;
			_buttonModalDebugPanel.Click += _buttonModalDebugPanel_Click;
		}

		private DebugPanel CreateDebugPanel()
		{
			var debugPanel = new DebugPanel
			{
				Opacity = 0.75f,
				Background = new ColoredRegion(DefaultAssets.WhiteRegion, Color.Blue)
			};

			_buttonDebugPanel.Enabled = false;
			_buttonModalDebugPanel.Enabled = false;

			debugPanel.Removed += (s, a) =>
			{
				_buttonDebugPanel.Enabled = true;
				_buttonModalDebugPanel.Enabled = true;
			};

			Desktop.Widgets.Add(debugPanel);

			return debugPanel;
		}

		private void _buttonDebugPanel_Click(object sender, System.EventArgs e)
		{
			CreateDebugPanel();

		}

		private void _buttonModalDebugPanel_Click(object sender, System.EventArgs e)
		{
			var debugPanel = CreateDebugPanel();
			debugPanel.IsModal = true;
		}
	}
}