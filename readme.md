# Modal System

![modal window](https://github.com/AwesomeOnPurpose/modal-window-system/blob/main/Screenshots/modal-window-example.png)

This is an implementation of the Modal Window System from the Game Dev Guide channel ([Making a Modal Window in Unity](https://www.youtube.com/watch?v=SzQABx2YTJA)).

The full details of the layout and system are covered in the video, but in short, this is a system to present a modal dialog to the player. It can present text, an image, and multiple interaction options (generally a confirm, cancel, and alternative option). There are vertical and horizontal options to present the data. And the pieces are modular with the help of the Unity UI Layout components.

## Additions in this version

1. Added method chaining to calls to the Modal Window
2. Added a Scriptable Object to control the colors and fonts of the modal window. 

### Method Chaining

[Method chaining](https://www.infoworld.com/article/3572598/how-to-use-fluent-interfaces-and-method-chaining-in-csharp.html) is a technique in which methods are called on a sequence to form a chain and each of these methods return an instance of a class. These methods can then be chained together so that they form a single statement.

	ModalWindow
	    .SetHorizontalContent("This is the horizontal layout with no image and no header text.")
	    .SetConfirmButton("OK", NextAction)
	    .SetCancelButton("Go back", PreviousAction)
	    .Show();

**Things to note about the API**:

* All buttons will close the window when clicked. This also means the action is an optional parameter when defining the buttons.
* The order of the buttons will determined by the order they are called, from left to right.
* The API expects either vertical or horizontal content, but there is no protection in place to prevent adding both.

### Modal Window Palette

This Scriptable Object has fields for most of the styling of the modal window, including the background color, the fonts for the header and content, and all of the styling options for the buttons.

![modal window styling](https://github.com/AwesomeOnPurpose/modal-window-system/blob/main/Screenshots/modal-window-palette.png)

#### Example

The first example is a series of prompts that use both the horizontal and vertical layouts. 

The second example is a basic confirmation dialog.

The example scene uses a Singleton, but that's not required.
