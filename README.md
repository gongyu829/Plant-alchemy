# Plant-alchemy
## lant AlchemyP植物炼金 :herb::potted_plant::fallen_leaf::leaves:
### :fog::milky_way::stars::tornado::snowflake::fire::cyclone::zap:
该项目提供了一个示例演示了如何使用空间定位来激活一个预设的AR场景以及其中相关的视觉效果，并且可以与视觉效果产生有趣的交互来体验炼金术！这是一款简单的收集合成小游戏，灵感来源于西方炼金术以及中国炼丹的过程。
_The project provides an example demonstrating how to use spatial localization to activate a preset AR scene along with its associated visual effects, and can interact with the visual effects to experience alchemy! It's a simple collection and synthesis mini-game, inspired by Western alchemy and the process of Chinese alchemy._


## What is Alant Alchemy什么是植物炼金 :herb::potted_plant::fallen_leaf::leaves:
### :earth_africa::earth_americas::earth_asia::globe_with_meridians::compass::night_with_stars:
“植物炼金”项目采用了lmmersal的空间映射和视觉定位系统，通过使用设备在物理世界中的精确定位来将数字内容与物理世界合并。该功能提供的地图信息可以使得我们在物理世界中叠加视觉效果来展现特别风景。
_The "Plant Alchemy" project utilizes lmmerseal's spatial mapping and visual localization system to merge digital content with the physical world by precisely positioning devices in the physical environment. The map information provided by this feature allows us to overlay visual effects in the physical world to showcase unique scenery._


该项目被定位为AR第一人称互动项目，用户可以通过手持iPad或者iPhone等移动设备来与虚拟视觉效果进行互动。通过扫描特定的空间可以显示一个充满了奇幻植物的场景。 :kaaba::synagogue::comet:
_The project is positioned as a first-person AR interactive experience where users can interact with virtual visual effects using handheld devices like iPads or iPhones. Scanning specific spaces reveals a scene filled with fantastical plants._
![](https://github.com/gongyu829/Plant-alchemy/blob/main/link/%E5%BC%80%E5%9C%BA.gif)

玩家手持设备靠近奇幻植物，在屏幕上点击特定的植物可以收取对应的素材并放置在下方UI栏里，可以通过重复点击来获取更多素材当然哪些植物可以收取素材就需要在场景进行探索！ :dizzy::point_left::palms_up_together::large_blue_diamond:
_Players approach fantastical plants with their devices, tapping specific plants on the screen to collect corresponding materials and place them in the UI bar below. Exploring the scene is necessary to discover which plants yield materials, and repeated tapping yields more resources._
![](https://github.com/gongyu829/Plant-alchemy/blob/main/link/%E7%82%B9%E5%87%BB.gif)

通过点击屏幕下方的的蓝色按钮来在空间中显示炼药瓶，将你收集到的素材拖动到炼药瓶的位置与其发生撞击，三个不同的素材可以合成一株奇特的新植物作为你炼金的成果。 :fist_right::wilted_flower::ear_of_rice::tea::tumbler_glass:
_By tapping the blue button at the bottom of the screen, players can summon alchemy flasks into the space. Dragging collected materials to the position of the flask and letting them collide results in the synthesis process. Three different materials can combine to create a unique new plant, serving as the outcome of your alchemical endeavors._
![](https://github.com/gongyu829/Plant-alchemy/blob/main/link/%E5%90%88%E6%88%90.gif)

## How does it work它是如何工作的 :mage_man:
### :raised_hands::eyes::zombie_man::person_fencing::horse_racing:
通过在unity中immersal的sdk实现了特定空间识别来进行数字世界和物理世界的融合，当你扫描到类似形状的物理空间后会生成特定的视觉效果。

_Through the implementation of lmmerseal's SDK in Unity, specific space recognition is achieved to merge the digital and physical worlds. When scanning similar-shaped physical spaces, specific visual effects are generated._

![](https://github.com/gongyu829/Plant-alchemy/blob/main/link/immersal%20sdk.png)


点击事件来处理UI的生成，并设置一个回归使其拖拽碰撞后返回UI栏。
_Handle the UI generation through click events and set up a callback to return the dragged item to the UI bar after collision detection._

![](https://github.com/gongyu829/Plant-alchemy/blob/main/link/dianji.png)

射线检测碰撞进行进度累计，随机生成炼金后的植物样本，随机数限制防止重复随机。
_Use raycasting collision detection to accumulate progress, randomly generate samples of alchemically synthesized plants, and implement restrictions on random numbers to prevent duplicates._

![](https://github.com/gongyu829/Plant-alchemy/blob/main/link/Manager.png)

## UI :mage:
UI部分主要承担了素材的生成与收集存放栏，控制炼药瓶的生成与隐藏事件。
_The UI section primarily handles the generation and storage of materials, as well as controlling the events for summoning and hiding the alchemy flasks._

![](https://github.com/gongyu829/Plant-alchemy/blob/main/link/UI.png)

## Requirements要求 :mage_woman:
This project aims to build an app runs on iOS devices.

1.Unity 2022.3.17f1c1

2.Xcode 15.2

3.iPhone with lidar capability

## How to use如何使用 :fairy_man:
1.Clone the project, open with Unity

2.Open Assets > Samples > Immersal SDK > 2.0.1 >Core Samples > Scenes >SimpleSample

3.Build this scene to an Xcode project 

4.Open Xcode, build app to your mobile device


# readmap :national_park:
## "Details of my personal creation and iteration process.
"我的个人创作与迭代详情
:classical_building::rock::hut::church::synagogue::foggy::night_with_stars:


## Project Workflow项目流程 :herb::potted_plant:
:diamond_shape_with_a_dot_inside::small_blue_diamond:方案的迭代与确认，概念图以及流程图的制作
_Iteration and confirmation of the solution, creation of conceptual and flow diagrams._


:diamond_shape_with_a_dot_inside::small_blue_diamond:找到一个合适套用的收集游戏模版资产，不太复杂方便删减修改以及导入移动端
_Find a suitable template asset for a collection game, which is not too complex and can be easily modified, trimmed, and imported for mobile devices._


:diamond_shape_with_a_dot_inside::small_blue_diamond:确认资产的细节与交互
_Confirm the details and interactions of the assets._


:diamond_shape_with_a_dot_inside::small_blue_diamond:模型资产的建模与购买
_Modeling and purchasing of asset models._


:diamond_shape_with_a_dot_inside::small_blue_diamond:将游戏模版资产构建到手机中尝试
_Build the game template assets into the phone and try._


:diamond_shape_with_a_dot_inside::small_blue_diamond:在项目上载入AR Foundation，构建虚拟网格
_Load AR Foundation in the project, construct a virtual grid._


:diamond_shape_with_a_dot_inside::small_blue_diamond:替换资产中的交互模型，更改交互设置
_Replace the interactive models in the assets, modify interaction settings._


:diamond_shape_with_a_dot_inside::small_blue_diamond:发现资产的不足与局限，仅导出该资产的UI部分与交互构架重新建立场景
_Identify deficiencies and limitations in the assets, only export the UI portion and interaction framework of the assets and rebuild the scene._


:diamond_shape_with_a_dot_inside::small_blue_diamond:用Immersal Mapper扫描一个预设好的空间为空间映射和视觉定位做准备
_Use Immersal Mapper to scan a pre-set space for spatial mapping and visual positioning preparation._


:diamond_shape_with_a_dot_inside::small_blue_diamond:用Scaniverse扫描该空间生成物理世界模型，进行物体更具体的定位
_Use Scaniverse to scan the space to generate a physical world model for more specific object positioning._


:diamond_shape_with_a_dot_inside::small_blue_diamond:在Unity中导入immersal的SDK，导入扫描好的空间特征点以及物理世界模型，比对定位
_Import Immersal's SDK into Unity, import scanned space features and physical world models, compare positioning._


:diamond_shape_with_a_dot_inside::small_blue_diamond:将交互目标与视觉资产摆放在预设空间上
_Place interactive targets and visual assets in the pre-set space._


:diamond_shape_with_a_dot_inside::small_blue_diamond:通过代码实现物体可以被点击并且生成一个对应图标
_Implement object clicking via code to generate a corresponding icon._


:diamond_shape_with_a_dot_inside::small_blue_diamond:设置另外一个小图标控制炼金瓶的出现与隐藏
_Set another small icon to control the appearance and disappearance of the alchemy bottle._


:diamond_shape_with_a_dot_inside::small_blue_diamond:实现UI栏里的图标可以被拖出，并与炼金瓶产生碰撞效果
_Implement the ability to drag icons from the UI bar and create collision effects with the alchemy bottle._


:diamond_shape_with_a_dot_inside::small_blue_diamond:设置UI碰撞后会消失并回到UI栏
_Set up the UI to disappear and return to the UI bar after collision._


:diamond_shape_with_a_dot_inside::small_blue_diamond:实现UI与物体碰撞后累计进度，且为不同UI图标，该进度累计到三后留下一个进行下一步的接口
_Implement the accumulation of progress after collision between the UI and objects, and for different UI icons, accumulate progress up to three before leaving an interface for the next step._


:diamond_shape_with_a_dot_inside::small_blue_diamond:下一步在指定位置随机生成9个预制物体中的其中一个，实现炼金目的
_Next, randomly spawn one of the nine preset objects at a specified location to achieve the alchemical objective._


:diamond_shape_with_a_dot_inside::small_blue_diamond:精调生成物体飘移问题，优化生成效果
_Fine-tune the drifting issue of the spawned objects and optimize the generation effect._


:diamond_shape_with_a_dot_inside::small_blue_diamond:设置随机范围限制重复生成
_Set random range limits to prevent repeated spawns._


:diamond_shape_with_a_dot_inside::small_blue_diamond:尝试物体的渲染隐藏与人物遮蔽
_Attempt rendering object hiding and character occlusion._


:diamond_shape_with_a_dot_inside::small_blue_diamond:初步跑通后的概念视频素材拍摄，第一人称实机与第三视角游玩现场
_Capture concept video footage after the initial test run, showcasing both first-person and third-person gameplay perspectives live on site._


:diamond_shape_with_a_dot_inside::small_blue_diamond:概念视频的剪辑，示意gif的制作
_Editing the concept video and creating illustrative GIFs._


## Released已发布 :mountain_snow:
1.空间映射和视觉定位
Spatial mapping and visual positioning


2.场景的构建和生成
Scene construction and generation


3.交互流程的成立
Establishment of interaction flow


4.交互长度和游玩内容的补充
Supplementary content for interaction duration and gameplay


## In Progress进行中 :mate:
1.开始UI界面的设计和实装，返回与退出游戏的设置
Designing and implementing the UI interface, setting up the return and exit game functions


2.手指点击动画与音效的设计和装载
Designing and loading finger click animations and sound effects


3.植物随风摇摆动画的制作与导入
Creating and importing animations for plants swaying in the wind


4.环境粒子特效的补充和制作导入
Supplementing and creating imports for environmental particle effects


## Planned计划 :ice_cube:
1.想要实现植物识别技术，将该项目从预设空间中解放出来，实现大空间游玩交互与扫描植物生成虚拟植物
Desire to implement plant recognition technology, liberating the project from predefined spaces, enabling large-scale interactive gameplay and generating virtual plants by scanning real ones.


2.空间映射和视觉定位迭代为实时生成
Iterating spatial mapping and visual positioning to real-time generation.


3.流程图的优化和补充
Optimizing and supplementing flowcharts.


## Under Consideration正在考虑中 :sake:
1.设备端的扩充，Holokit以及Rokid端的拓展
Expansion of device capabilities, including extensions for Holokit and Rokid devices.


2.从屏幕点击交互迭代为手势交互，可以与空间中的虚拟植物进行交互
Iterating from screen tap interactions to gesture-based interactions, enabling interaction with virtual plants in the space.


3.更精美的植物模型与生产模型的制作
Creating more refined plant models and production models.


## Scheme iteration方案迭代 :cocktail:
:roller_coaster::ferris_wheel::mountain_railway:1.错位时空：视错觉通关小游戏（通过机关与现实形成视错觉搭建道路达到通关目的）
Displaced Spacetime: A visual illusion puzzle game (players navigate through illusions by manipulating mechanisms to construct paths in reality).


:microbe::blossom::seedling:2.草木园林：收集与种植小游戏（可以多人互动种植物品）
Flora Garden: A collecting and planting mini-game (allows multiplayer interaction in planting various flora).


:dragon::evergreen_tree::herb:3.生命本位：生态纪元（通过植物本身探讨时间的命题，过去现在未来在时间线上的呈现）
Life-Centric: Eco Epochs (explores the concept of time through plants, presenting the past, present, and future on a timeline).


:leaves::fallen_leaf::shamrock:4.植物炼金
扫描地面上的植物，生成一株数字植物
点击收集它的本体或者炼金材料，收集有时间限制，被收集的植物产生形态改变
炼金材料产生的数量不同与稀有程度的区分，造成炼金结果的不同
Plant AlchemyP: Scan plants on the ground to generate a digital plant. Click to collect its essence or alchemical materials within a time limit, causing morphological changes to the collected plant. Different quantities and rarities of alchemical materials lead to different alchemical results.


## About Me关于我
:electron:游离在宇宙之外 :first_quarter_moon::feather: Adrift Beyond the Universe:electron: