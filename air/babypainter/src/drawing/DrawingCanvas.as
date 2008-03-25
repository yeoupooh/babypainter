// ActionScript file
package drawing
{
	import flash.display.Graphics;
	import flash.events.MouseEvent;
	
	import mx.containers.Canvas;
	
	public class DrawingCanvas extends Canvas
	{
		private var prevX:Number;
		private var prevY:Number;
		
		public var fgColor:uint = 0x000000;
		public var bgColor:uint = 0xffffff;
		public var lineThickness:Number = 2;
		
		public function DrawingCanvas():void
		{
			this.addEventListener(MouseEvent.MOUSE_DOWN, mouseDown);
			this.addEventListener(MouseEvent.MOUSE_MOVE, mouseMove);
			this.addEventListener(MouseEvent.MOUSE_UP, mouseUp);
		}
		
		private function mouseDown(event:MouseEvent):void
		{
			trace("mouse down");
			
			this.graphics.moveTo(event.localX, event.localY);
			prevX = event.localX;
			prevY = event.localY;
		}
		
		private function mouseMove(event:MouseEvent):void
		{
			if (event.buttonDown == true)
			{
			trace("mouse move");
			trace("localX=" + event.localX);
			trace("stageX=" + event.stageX);

				var g:Graphics = this.graphics;
			
	        	g.lineStyle(lineThickness, fgColor, 1.0);
	        	g.beginFill(0xaaaaaa, 0.5);
        	
				g.moveTo(prevX, prevY);
				g.lineTo(event.localX, event.localY);
				
				g.endFill();
				
				prevX = event.localX;
				prevY = event.localY;
			}
		}
		
		private function mouseUp(event:MouseEvent):void
		{
			trace("mouse up");
		}
		
		public function clearAll():void
		{
			var g:Graphics = this.graphics;
			
			g.clear();
			
	    	//g.lineStyle(0, bgColor, 0);
	    	g.beginFill(bgColor, 1.0);
		
			g.drawRect(0, 0, this.width, this.height);
			
			g.endFill();
		}
	}
}