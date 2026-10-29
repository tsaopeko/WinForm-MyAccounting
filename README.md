# 個人記帳系統（Personal Accounting System）

## 📌 專案簡介

這是一個使用 C# Windows Forms 開發的個人記帳系統，透過圖形化介面管理日常收入與支出，並提供統計分析及行事曆功能，方便使用者記錄日常財務與安排生活行程。

## ✨ 功能介紹

### 1. 首頁
- 顯示系統首頁。
- 查看當日行程。
- 快速掌握今日待辦事項。

### 2. 收支管理
- 新增、查詢及管理收入與支出紀錄。
- 記錄日期、收支類型、分類、金額及備註。
- 使用資料表呈現記帳資料。

### 3. 統計分析
- 使用長條圖呈現收支統計。
- 使用圓餅圖呈現分類資料。
- 協助使用者了解日常財務狀況。

### 4. 行事曆
- 查看日期及管理行程。
- 新增、修改及刪除行程。
- 查看指定日期的行程安排。

## 🛠️ 使用技術

- **程式語言：** C#
- **開發框架：** Windows Forms（.NET Framework 4.x）
- **開發工具：** Visual Studio
- **資料庫：** SQL Server LocalDB
- **資料存取：** ADO.NET
- **圖表呈現：** Windows Forms Chart

## 🗄️ 資料庫設定

本專案使用 SQL Server LocalDB 儲存資料。

目前使用的連線字串：

```text
Server=(localdb)\MSSQLLocalDB;Database=MyAccounting;Integrated Security=True;
```

請在執行程式前確認：

1. 電腦已安裝相容的 .NET Framework。
2. 電腦已安裝 SQL Server LocalDB。
3. 已建立 `MyAccounting` 資料庫。
4. 資料庫內已建立程式所需的資料表。

> 注意：僅下載或複製程式的 `.exe` 檔案，不會自動建立資料庫。若要在其他電腦執行，需要另外準備資料庫及相應環境。

## 🚀 如何執行

### 使用 Visual Studio

1. 將專案複製或下載到本機。
2. 使用 Visual Studio 開啟 `.sln` 方案檔。
3. 確認資料庫連線字串及資料庫設定。
4. 確認專案所需的套件與參考均已安裝。
5. 建置方案。
6. 執行專案。

### 執行已建置的程式

1. 使用 Visual Studio 將組態切換為 `Release`。
2. 建置方案。
3. 前往專案的 `bin\Release` 輸出資料夾。
4. 執行專案產生的 `.exe` 檔案。

請保留執行程式所需的其他檔案，並確認目標電腦已具備必要的執行環境及資料庫。

## 📂 專案功能模組

| 模組 | 說明 |
|---|---|
| HomeForm | 首頁及今日行程 |
| AccountForm | 收入與支出管理 |
| CalendarForm | 行事曆及行程管理 |
| CalendarRepository | 行程資料存取 |
| CalendarRecord | 行程資料模型 |
| DbConnection | 資料庫連線管理 |

## 📈 後續規劃

- 持續改善操作介面。
- 優化收支統計與資料呈現。
- 增加更多財務管理功能。
- 持續改善行事曆使用體驗。

## 📝 專案說明

本專案為個人學習與實作作品，主要用於練習 C# WinForms、資料庫操作、圖表呈現及應用程式介面設計。
