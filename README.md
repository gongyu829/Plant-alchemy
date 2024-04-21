# Plant-alchemy
## Plant Alchemy植物炼金 :herb:
该项目提供了一个示例演示了如何使用空间定位来激活一个预设的AR场景以及其中相关的视觉效果，并且可以与视觉效果产生有趣的交互来体验炼金术！这是一款简单的收集合成小游戏，灵感来源于西方炼金术以及中国炼丹的过程。

_The project provides an example of how to use spatial positioning to activate a preset AR scene and related visual effects, and can produce interesting interactions with visual effects to experience alchemy! This is a simple collection and synthesis game, inspired by the process of Western alchemy and Chinese alchemy._

## What is Alant Alchemy什么是植物炼金 :herb:
“植物炼金”项目采用了lmmersal的空间映射和视觉定位系统，通过使用设备在物理世界中的精确定位来将数字内容与物理世界合并。该功能提供的地图信息可以使得我们在物理世界中叠加视觉效果来展现特别风景。

_The "Plant Alchemy" project adopts lmmersal's spatial mapping and visual positioning system to combine digital content with the physical world by using the precise positioning of the device in the physical world. The map information provided by this function allows us to superimpose visual effects in the physical world to show special scenery._

该项目被定位为AR第一人称互动项目，用户可以通过手持iPad或者iPhone等移动设备来与虚拟视觉效果进行互动。通过扫描特定的空间可以显示一个充满了奇幻植物的场景。

_The project is positioned as an AR first-person interactive project, and users can interact with virtual visual effects through mobile devices such as iPad or iPhone. A scene full of fantasy plants can be displayed by scanning a specific space._

玩家手持设备靠近奇幻植物，在屏幕上点击特定的植物可以收取对应的素材并放置在下方UI栏里，可以通过重复点击来获取更多素材当然哪些植物可以收取素材就需要在场景进行探索！ :dizzy:

_Players can hold the device close to the fantasy plant. Click on a specific plant on the screen to collect the corresponding material and place it in the UI bar below. You can click repeatedly to get more material. Of course, which plants can collect the material needs to be explored in the scene!_

通过点击屏幕下方的的蓝色按钮来在空间中显示炼药瓶，将你收集到的素材拖动到炼药瓶的位置与其发生撞击，三个不同的素材可以合成一株奇特的新植物作为你炼金的成果。

_By clicking the blue button at the bottom of the screen to display the refining bottle in the space, drag the material you have collected to the position of the refining bottle to collide with it. Three different materials can synthesize a strange new plant as the result of your alchemy._

## How does it work它是如何工作的
通过在unity中immersal的sdk实现了特定空间识别来进行数字世界和物理世界的融合，当你扫描到类似形状的物理空间后会生成特定的视觉效果。

_The fusion of the digital world and the physical world is realized through the specific spatial recognition of immersal sdk in unity. When you scan a physical space of a similar shape, a specific visual effect will be generated._

点击事件来处理UI的生成，并设置一个回归使其拖拽碰撞后返回UI栏。

_Click the event to handle the UI generation, and set a regression to drag and drop it back to the UI bar after the collision._

射线检测碰撞进行进度累计，随机生成炼金后的植物样本，随机数限制防止重复随机。

_The progress of ray detection and collision is accumulated, and the plant samples after alchemy are randomly generated. The random number is limited to prevent repeated randomization._

## UI
UI部分主要承担了素材的生成与收集存放栏，控制炼药瓶的生成与隐藏事件。

_The UI part is mainly responsible for the generation and collection and storage of materials, and controls the generation and hidden events of refining bottles._

## Requirements要求
This project aims to build an app runs on iOS devices.

1.Unity 2022.3.17f1c1

2.Xcode 15.2

3.iPhone with lidar capability

## How to use如何使用
1.Clone the project, open with Unity

2.Open Assets > Samples > Immersal SDK > 2.0.1 >Core Samples > Scenes >SimpleSample

3.Build this scene to an Xcode project 

4.Open Xcode, build app to your mobile device
