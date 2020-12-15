# Project4_Unity

<div dir='rtl' lang='he'>

במטלה זו היינו צריכות לשנות מספר דברים במשחק הנתון.
בחרנו לשנות את הדברים הבאים :
1)
מכונת מצבים של האויב 
בסצטנה הקרויה 
"State Machine"
IState כל המצבים של האויב ממשים את 
בInterface 
קיימות 2 פונקציות אותן חייב לממש
Exit()
Enter()
וכך הפעלנו כל מצב.

[תלחץ כאן על מנת לראות את הסצנה](https://github.com/ComputerGame0/Project4_Unity/tree/main/Assets/Scenes/3-enemies)

החלפנו את מצבי האויב כך שיעשה את הדברים הבאים :

## ירדוף אחרי השחקן
במידה והשחקן "מתחבא" בשיחים האויב לא יכול לרדוף אחריו-
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/Chaser.cs)

בקוד זה :
האויב מקבל את השחקן אחריו צריך לרדוף,
ואת האריח בו השחקן יכול להתחבא מפניו.
הקוד מממש את הממשק : IState
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/IState.cs)

ולכן יש לו פונקציית התחלה וסיום.

## מצב שמירה
האויב נמצא בשמירה תמידית עד שהשחקן נכנס לו לטווח ראיה

[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/Guard.cs)

 Enter בקוד, בפונקציית  
האויב חוזר למקומו ההתחלתי

## מצב חסימה
כאשר השחקן מתחבא (בשיחים) האויב מנסה לחסום את השחקן משני הצדדים של השחקן
בעזרת 2 הרים (דרכם השחקן לא יכול לעבור) וכך השחקן מוגבל בתזוזתו.
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/Change_the_world.cs)

ויצרנו מחלקה המחזיקה מצש נוכחי של האויב:
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/StateMachine.cs)

ויצרנו מחלקה העוברת בין במצבים השונים לפי תזוזות השחקן ומיקומיו:
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/EnemyControllerStateMashine.cs)


2)
בנוסף מימשו שינוי ביכולות השחקן:
השחקן יכול לחצוב בהר
בעזרת המקשים :
X וחיצי המקלדת
דבר זה יקח כמה שניות 

[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/2-player/KeyboardQuarrying.cs)

3)
מימשו יצירת עולם באופן רנדומלי ושינויים על מנת שיווצר עולם הגיוני

