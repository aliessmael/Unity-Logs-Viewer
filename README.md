# Unity-Logs-Viewer
Using this tool you can easily check your editor console logs inside the game itself! 
All what you have to do is to make a circle gesture using your mouse (click and drag) or your finger (touch and drag) on the mobile screen to show all these logs! 

You can download also from unity asset store
https://www.assetstore.unity3d.com/en/#!/content/12047

To setup log viewer do the following
<li>1 - create reporter from menu (Reporter->Create) at first scene your game start . </li>
<li>2 - then set the ” Scrip execution order ” in (Edit -> Project Settings ) of Reporter.cs to be the highest.</li>
<li>3 - in reporter.cs at first line choose the proper #define which is matching your unity version, also do the same for testReporter.cs
    <ul>
    <li>#define UNITY_CHANGE1 for unity older than "unity 5"</li>
    <li>#define UNITY_CHANGE2 for unity 5.0 -> 5.3</li>
    <li>#define UNITY_CHANGE3 for unity 5.3 (fix for new SceneManger system  )</li>
    <ul>
    </li>

<a href="https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=J9MX5C6Q7B2NY">
    <img src="https://www.paypalobjects.com/webstatic/en_US/btn/btn_donate_cc_147x47.png">
    </img>
</a>
