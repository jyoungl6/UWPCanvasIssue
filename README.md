.# UWPCanvasIssue
Sample project for reproducing an issue with initializing control on a Canvas in the Loaded event. The problem is that controls added to a Canvas.Children collection during the Loaded event of the Canvas are not having their UI displayed. Factoring into the problem is that the Height and Width of the canvas is being set in the constructor of the MainPage, after InitializeComponents. If this adjustment of the Canvas size is removed then the controls are created and displayed normally.

This project is in reference to a Microsoft forum thread.
https://social.msdn.microsoft.com/Forums/en-US/401ac1d9-a75f-44fa-9613-ae04c61d999a/uwp-odd-canvas-control-behavior?forum=wpdevelop
