Feature: DotNetFiddleRun
	As a user of DotNetFiddle, I should be able 
	To navigate to the HomePage, Click the Run Button
	See the output window, Click the hide options button
	To ensure that the hide button is not displayed
	

Scenario: Hello World_01_Verify that hello world is displayed successfully
	Given dotnetfiddle is fully loaded
	When a user clicks the the run button
	Then Hello World text is expected

Scenario: Hidden Option Panel_02_Verify that option panel can be hidden successfully
	Given dotnetfiddle is fully loaded
	When a user clicks the the option panel button
	Then the option panel should be hidden and > displayed successfully
	And Hello World text is expected
