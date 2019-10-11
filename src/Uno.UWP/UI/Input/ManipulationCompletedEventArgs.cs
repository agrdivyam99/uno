using Windows.Devices.Input;
using Windows.Foundation;

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input
{
	public partial class ManipulationCompletedEventArgs 
	{
		internal ManipulationCompletedEventArgs(PointerDeviceType pointerDeviceType, Point position, ManipulationDelta cumulative)
		{
			PointerDeviceType = pointerDeviceType;
			Position = position;
			Cumulative = cumulative;
		}

		public PointerDeviceType PointerDeviceType { get; }
		public Point Position { get; }
		public ManipulationDelta Cumulative { get; }
	}
}
