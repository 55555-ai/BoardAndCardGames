#21點卡牌遊戲（21-Point Card Game）

##專案簡介
本專案使用 C# Windows Forms 開發，製作一個經典的 21 點卡牌遊戲 。使用者可以在畫面上進行抽牌，系統會動態將撲克牌面顯示於手牌清單中，並結合背景倒數計時器與多媒體音效播放，提供極具互動感的卡牌遊戲體驗 。本系統整合 ListView、ImageList、Timer 與 SoundPlayer 等元件，展現視窗程式設計的事件驅動核心技術 。


##功能說明

###卡牌動態顯示
使用 ListView 搭配 ImageList 控制項，於發牌時將抽到的撲克牌圖片整齊並排顯示於玩家手牌區 。

###思考倒數計時
內建計時器功能，每局提供 30 秒思考時間，畫面上會即時同步倒數，若時間歸零則判定超時落敗。

###點數即時計算
每次抽牌後，系統會自動將牌面點數累加，並即時更新於「當前牌點」標籤中。

###爆牌自動判定
當玩家總點數超過 21 點時，系統會立即中斷賽局、停用控制按鈕，播放失敗音效並跳出爆牌提示。

###電腦結算勝負
點擊過牌後，系統會動態生成電腦點數並進行賽局結算，依據點數高低判定勝、負或平手，並觸發對應的輸贏音效 。

###音效多媒體整合
遊戲中整合多種聲音事件，包含勝利音效以及失敗音效，提升整體遊戲帶入感 。


##執行說明

###開發環境
* Visual Studio 2022
* .NET Framework（Windows Forms）

###執行步驟
1. 開啟專案（BoardAndCardGames.sln）
2. 點擊「開始（Start）」執行程式
3. 觀察「剩餘時間」倒數計時
4. 點擊【發牌】按鈕進行抽牌，檢視手牌與點數變化 
5. 點擊【過牌】按鈕結束抽牌，進行電腦結算
6. 點擊【重新開始】按鈕清空牌面，重置新賽局


##執行畫面
<img width="1643" height="1601" alt="image" src="https://github.com/user-attachments/assets/57126be7-93e9-479f-ab5d-694c48d5aa1b" />

###遊戲主畫面
<img width="1180" height="911" alt="image" src="https://github.com/user-attachments/assets/a85e2df7-1e9f-4c7d-9478-d5642d75c822" />

### 發牌抽牌畫面
<img width="1045" height="782" alt="image" src="https://github.com/user-attachments/assets/f004b384-07c6-48e1-98d0-49f6c26dbc73" />
<img width="1044" height="788" alt="image" src="https://github.com/user-attachments/assets/2f9bb61e-3e29-42ca-9aa3-402f1f31fdae" />

### 爆牌結束畫面
<img width="1208" height="803" alt="image" src="https://github.com/user-attachments/assets/998014eb-e7d6-41ea-9521-4393176083f4" />

### 過牌結算勝負（彈出視窗）
<img width="1048" height="795" alt="image" src="https://github.com/user-attachments/assets/3d3dd8c1-9371-4bb5-ab2a-bd46ab0680d9" />
<img width="1099" height="796" alt="image" src="https://github.com/user-attachments/assets/56bcc112-7fe5-43c2-81f2-29d193a14b33" />

### 思考超時提示
<img width="1076" height="781" alt="image" src="https://github.com/user-attachments/assets/95ef944c-f2d5-49ef-8ee5-04e5ed3a527e" />

## 使用技術
* C#
* Windows Forms
* ListView
* ImageList
* Timer
* SoundPlayer
* 隨機洗牌演算法（Fisher-Yates Shuffle）
* 視窗事件驅動（Click, Load, FormClosing Event）

## 專案架構
BoardAndCardGames
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── BoardAndCardGames.sln
├── README.md
└── sounds
    ├── deal.wav
    ├── win.wav
    └── lose.wav



##開發紀錄
本專案透過 GitHub 進行版本控制，提交紀錄清楚記錄以下開發過程 ：
* 建立 Windows Forms 21點遊戲主介面 
* 匯入撲克牌圖片至 ImageList 並調整 ImageSize 
* 實作洗牌演算法與牌組初始化邏輯
* 加入 ListView 動態手牌顯示功能 
* 新增發牌按鈕與點數累加邏輯
* 加入過牌按鈕與電腦隨機點數結算邏輯
* 整合 SoundPlayer 播放發牌與輸贏音效 
* 新增 Timer 計時器實作 30 秒倒數功能
* 實作 21 點爆牌與超時判定機制
* 加入 FormClosing 關閉視窗確認功能
* 建立 .gitignore 過濾編譯暫存檔 
* 撰寫 README 與遊戲執行畫面截圖
