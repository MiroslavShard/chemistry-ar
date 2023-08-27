# Chemistry AR
AR mobile application for my school project. There are 7 chemical elements (atoms) and one reaction (molecule). Built for Android platform, but has iOS support. Requires Android 7.0 and later. To open this project you need Unity 2021.3.28f1 (LTS) or later.


## Screenshots
<img src="https://github.com/MiroslavShard/chemistry-ar/blob/main/Chemistry%20AR/Media/Photos/1.jpg" width="49%" height="49%"> <img src="https://github.com/MiroslavShard/chemistry-ar/blob/main/Chemistry%20AR/Media/Photos/6.jpg" width="49%" height="49%">
<img src="https://github.com/MiroslavShard/chemistry-ar/blob/main/Chemistry%20AR/Media/Photos/7.jpg" width="49%" height="49%"> <img src="https://github.com/MiroslavShard/chemistry-ar/blob/main/Chemistry%20AR/Media/Photos/8.jpg" width="49%" height="49%"> 
<img src="https://github.com/MiroslavShard/chemistry-ar/blob/main/Chemistry%20AR/Media/Photos/9.jpg" width="49%" height="49%"> <img src="https://github.com/MiroslavShard/chemistry-ar/blob/main/Chemistry%20AR/Media/Photos/13.jpg" width="49%" height="49%"> 
<img src="https://github.com/MiroslavShard/chemistry-ar/blob/main/Chemistry%20AR/Media/Photos/15.jpg" width="49%" height="49%">


## Videos
<a href="https://www.youtube.com/watch?v=7lIZQ3iKIzc"><img src="https://img.youtube.com/vi/7lIZQ3iKIzc/0.jpg" width="49%" height="49%"></a>
<a href="https://www.youtube.com/watch?v=nW2wcJIgf4A"><img src="https://img.youtube.com/vi/nW2wcJIgf4A/0.jpg" width="49%" height="49%"></a>


## Can I use this project?
Of course yes! Also feel free to ask any questions about the project, I will try to answer asap 😉 I will be very grateful if you improve this application (for example, add new atoms and reactions) and make a pull request 💪


## How can I add new atoms?
1. Generate a marker for the new element using the [ArUco markers generator](https://chev.me/arucogen/).
2. Make the a card with a marker (if you want to use my design, you can use my [Figma project](https://github.com/MiroslavShard/chemistry-ar/tree/1.1.0/Chemistry%20AR/Figma)).
3. Import a card into the Unity project.
4. Add a card to the `ReferenceImageLibrary` file, set the element name and physical size of the card.
5. Make a prefab for a new element (you can copy an already created element and redesign it).
6. Add a prefab to the scene and add it to the `Object library`.
7. Double check the element name in the `ReferenceImageLibrary` and in the `Object Library`, because they must be the same.
8. If you want to have 2+ identical elements on the screen, just create a new one with a number (like I created Hydrogen).


## Important notes
1. Never use spaces in the Unity XR project path. Unity cannot create XR Reference Image Library if project path contains spaces.
2. Never use QR codes for AR image tracking. Instead of QR codes you can use AR markers. The marker generator I used in this project is [ArUco markers generator](https://chev.me/arucogen/).


## Build with
• Unity 2021.3.28f1 (LTS)<br>
• Google ARCore & Apple ARKit


## Contacts
<a href="https://www.instagram.com/miroslavshard/"><img src="https://img.shields.io/badge/instagram-%23E4405F.svg?&style=for-the-badge&logo=instagram&logoColor=white"></a> <a href="mailto:miroslavshard@gmail.com"><img src="https://img.shields.io/badge/Gmail-D14836?&style=for-the-badge&logo=gmail&logoColor=white"></a>


<br><i>Made in Ukraine under fire</i><br>
<b>© Miroslav Stetsiuk - 2023</b>
