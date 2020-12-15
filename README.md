# Project4_Unity

<div dir='rtl' lang='he'>

במטלה זו היינו צריכות לשנות מספר דברים במשחק הנתון. <br />
בחרנו לשנות את הדברים הבאים : <br />
 ## 1) מכונת מצבים של האויב
בסצטנה הקרויה <br /> 
"State Machine" <br />
 כל המצבים של האויב מממשים את 
Interface IState <br />
קיימות 2 פונקציות אותן חייב לממש
Exit() <br />
Enter() <br />
וכך הפעלנו כל מצב. <br />


[תלחץ כאן על מנת לראות את הסצנה](https://github.com/ComputerGame0/Project4_Unity/tree/main/Assets/Scenes/3-enemies) <br />

החלפנו את מצבי האויב כך שיעשה את הדברים הבאים : <br />

## ירדוף אחרי השחקן
במידה והשחקן "מתחבא" בשיחים האויב לא יכול לרדוף אחריו- <br />
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/Chaser.cs) <br />

בקוד זה : <br />
האויב מקבל את השחקן אחריו צריך לרדוף, <br />
ואת האריח בו השחקן יכול להתחבא מפניו. <br />
הקוד מממש את הממשק : IState <br />
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/IState.cs) <br />

ולכן יש לו פונקציית התחלה וסיום. <br />

## מצב שמירה
האויב נמצא בשמירה תמידית עד שהשחקן נכנס לו לטווח ראיה

[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/Guard.cs) <br />

 Enter בקוד, בפונקציית <br /> 
 האויב חוזר למקומו ההתחלתי

## מצב חסימה
כאשר השחקן מתחבא (בשיחים) האויב מנסה לחסום את השחקן משני הצדדים של השחקן
בעזרת 2 הרים (דרכם השחקן לא יכול לעבור) וכך השחקן מוגבל בתזוזתו. <br />
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/Change_the_world.cs) <br />

ויצרנו מחלקה המחזיקה מצב נוכחי של האויב: <br />
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/StateMachine.cs) <br />

ויצרנו מחלקה העוברת בין במצבים השונים לפי תזוזות השחקן ומיקומיו: <br />
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/3-enemies/EnemyControllerStateMashine.cs) <br />

![תמונה2](https://user-images.githubusercontent.com/57682267/102245518-54cce580-3f06-11eb-8e28-1abd2657aae6.png)

בתמונה ניתן לראות את השחקן מתחבא בשיחים, <br />
האויב חסם אותו משני צידיו<br />
והאויב לא נמצא ברדיפה כי השחקן רחוק ממנו, <br />
האויב נמצא במצב שמירה <br />


## 2) בנוסף מימשו שינוי ביכולות השחקן:

השחקן יכול לחצוב בהר
בעזרת המקשים : <br />
X וחיצי המקלדת
דבר זה יקח כמה שניות 

[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/2-player/KeyboardQuarrying.cs) <br />

## 3) מימשו יצירת עולם באופן רנדומלי ושינויים על מנת שיווצר עולם הגיוני
לקחנו את הקוד הקיים היוצר מערה מ-2 סוגי אריחים  <br />
ושינינו על מנת שנוכל לקבל עוד סוג אריח להוספה.  <br />
שינינו בקוד את האפשרות ליצור מספרים רנדומלים  <br />
 <br /> במקום ליצור 0/1
 <br /> יצרנו  0/1/2
בצורה רנדומלית <br />
ובקוד אשר מסדר את המפה  <br />
הוספנו את האופציה להתחשב גם באריח נוסף כך שאם מזהה לידו את אותו הסוג  <br /> 
משתנה לפיו.  <br />


הקוד הבא אחראי על יצירת המפה בצורה רנדומלית ושינוי המפה לצורה הגיונית: <br />

[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/4-generation/CaveGenerator.cs) <br />

הקוד הבא אחראי על ציור המפה ע"י האריחים השונים: <br />

[תלחץ כאן על מנת לראות את הקוד האחראי]( https://github.com/ComputerGame0/Project4_Unity/blob/main/Assets/Scripts/4-generation/TilemapCaveGenerator.cs
) <br />

![תמונה1](https://user-images.githubusercontent.com/57682267/102245824-ae351480-3f06-11eb-9dc7-ad3c571239df.png)




