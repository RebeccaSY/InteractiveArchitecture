# Time Warp Architecture Journey in VR
**A journey through the architectural evolution in various parts of the world**

## Technique:

https://accelerate-immersive-framework.web.app/  
https://github.com/ual-cci/accelerate-immersive-framework/tree/main/docs  
https://jgbarah.github.io/aframe-playground/  
https://aframe.io/aframe/examples/  
https://aframe.io/docs/1.4.0/introduction/  

## Used in practical component: 
VR Hands: https://www.youtube.com/redirect?event=video_description&redir_token=QUFFLUhqbmw3NmkxTFZCSjU2VlFVZDdZOXFoWkh2YjBEd3xBQ3Jtc0ttSXZWbUtnLTBOR2hkNzRKY0NnWGdsNmhtVVRkREI3ZDZUZWg4WHZfQ1A3YUFxZWlBRHNyc053d2d1WmNxRXpqYy03U1NzWUlXcXIyVjBnOURoVkhyLUxMd0VfZFFaV1NCMV9GT2ZveDBBZmJrRkc3dw&q=https%3A%2F%2Fdrive.google.com%2Ffile%2Fd%2F10b39IekUdpBHlcTslZ-BlNRyH5uqPUe1%2Fview%3Fusp%3Dsharing&v=8PCNNro7Rt0  

Youtube tut: https://www.youtube.com/watch?v=8PCNNro7Rt0  
https://www.youtube.com/watch?v=pMOHX1qD2bE&list=PLpEoiloH-4eM-fykn_3_QcJ-A_MIJF5B9&index=16  
https://www.youtube.com/watch?v=ly9mK0TGJJo  

## Models:
CGTrader: https://www.cgtrader.com
TurboSquid: https://www.turbosquid.com/zh_cn/3d-models/3d-model-parrot-character-2011751#
Open3DModel: https://open3dmodel.com/3d-models

## Images:
Arrow Image by macrovector on Freepik  

## Design Process
June 16th:  
initial proposal & discussion  
The initial inspiration comes from differences and commonalities, but many details are not universal, especially those related to human thoughts, which can vary from person to person. Perhaps only natural geographical conditions can be objectively described, along with some established facts.  

June 23th:  
(Remote) Self-study on architecture development history  
Get to know some famous buildings, seek inspiration through their introductions, design concepts, processes, and influences.
Also look for related art works and research.  

July 7th:  
Start looking for scholar references which talk about architecture, and application in VR.  
continue look at related works  

August 4th:  
(Remote) Review of VR skills with Unity. In my previous projects, most of the interaction was based on click-events from controller buttons. There were some UI canvas attached for users to get information, but this added to cognitive load for the experience. In this VR project, I would try to make it easier by avoiding too much text reading.  

August 23th:  
Selection of styles and elements.  
I decided to choose some of the main styles which have influenced this history. I also preferred the places where I have visited.  

September 2nd:  
Continue to learn Accelerate webVR, looking for examples.  

(busy with moving home, fell ill after back to London. Progress paused for some time)

October 13th:  
The setup of the VR project encountered difficulties. The package manager takes a long time to open, sometimes even after waiting for an hour, it is still loading. I cannot afford to wait like this every time, as it is frequently needed. Running the project is also very slow, taking more than ten minutes. There might be an issue with the data connection of the VR headset, and in Unity's run options, I have to refresh several times to find the recognized device.  

I updated Unity to the 2022 version, and the issue is resolved. The package manager is working fine now. It's possible that the previous 2020 version was too outdated and didn't match with the new modules. Build and run is also much faster now.  

A plan for the steps of experience  
![Image text](https://github.com/RebeccaSY/InteractiveArchitecture/blob/main/sketches/plan01.png)  
![Image text](https://github.com/RebeccaSY/InteractiveArchitecture/blob/main/sketches/plan02.png)  

October 27th:  
Using UI for guidance is essential. Based on my previous experience, many users are unfamiliar with VR, and they tend to get lost in the virtual space. I've set up the UI to be toggleable at any time, and it's not in world space. When the button on the left controller is pressed, it opens and appears in front of the user, and closes if pressing the button’s pressed again.  

November 8th:  
Due to the large number of materials, I have many 'hoverEntered' events that require changing the render material of many objects. I override this part using a script I write by myself, relying on the built-in XR Simple Interactable. It reads the Tag of the GameObject, and as long as it conforms to the Tag, executes the operation uniformly.

Details to be considered/finished (3D models to be done):  
![Image text](https://github.com/RebeccaSY/InteractiveArchitecture/blob/main/sketches/plan_more.png)  
  
2D to 3D change was given up.  
Reasons were considered more.  
  
November 18th:  
VR project set up and testing. Users usually get confused about which button on the controller to press.

November 22th:  
Add an arrow under character’s feet, pointing to where the user should head to
Add an illustration of controller usage on the instruction UI page, to make the operation explanation clear for users. Many users spend a lot of time understanding how each button on the controllers work.  

## Video Demo: 
https://youtu.be/IO8qsTlqXsc  


