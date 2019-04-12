// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace AnnoBibLibraryMac
{
	public partial class MarginSplitView : NSSplitView
	{
		public MarginSplitView (IntPtr handle) : base (handle)
		{
		}

        public float LeftMargin { get; set; }
        public float RightMargin { get; set; }

        public bool CanSnap { get; set; }

        [Export("draggingUpdated:")]
        public override NSDragOperation DraggingUpdated(NSDraggingInfo sender)
        {
            base.DraggingUpdated(sender);

            if (sender.DraggingLocation.X < LeftMargin)
                SetPositionOfDivider(LeftMargin, 0);
            Console.WriteLine(sender.DraggingLocation.X);

            return NSDragOperation.Move;
        }
    }
}
