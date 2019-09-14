# Anomaly detection using AR

This project is an attempt to develop an Augmented Reality application for diagnosing anomalies in vehicles.
Finding malfunctions in code or machines is an assiduous task. The time spent in identfying the problem often supersedes that of solving the issue.
Using an [OBD 2](https://en.wikipedia.org/wiki/On-board_diagnostics) sensor and leveraging the power of AR pinpointing the exact location of the issue becomes effortless.


## Dependencies

The build of this AR application can be simplfied into three stages.
1. Augument a vehicle's model and allow for information to be displayed.
2. Store data from the OBD 2 sensors and display them in app.
3. Analyse for anomalies in the data.

There are several amazing tools and frameworks out there to that allow you to tinker with AR applications. After a very long and demanding search for the rigth tools.
We decided to use these because, well we got these to work.
1. Unity 3D for rendering the application. It doesn't natively allow for augumenting objects but Vuforia Engine paired with Unity works magic.
2. OBD 2 pairs with devices over bluetooth. To store the incoming stream of data from the sensor in a database we used [android-obd-reader](https://github.com/pires/android-obd-reader) project.
3. The analysis of the data..

## Installation

Refer the following installation guides listed in sequence.
1. Unity 3D - https://unity3d.com/get-unity/download
2. Vuforia Engine - https://library.vuforia.com/articles/Training/getting-started-with-vuforia-in-unity.html .
Vuforia Engine-powered Unity apps are built and run in the same way as other Unity apps for Android, iOS, and UWP. This guide should also set you up with the a basic AR app.
3. OBD 2 reader [get API here https://github.com/pires/obd-java-api/]. (Do check out the project link included in the dependencies section.)

## Usage 

1. The previous steps would hae left you with an app augumenting an astronaut.
2. The contents of the 300TDi folder include the files for augumenting a vehicle and and engine with some cool opening animations.

## License
[MIT](https://choosealicense.com/licenses/mit/)
