   M S B A M L   `   `   `  ????Q  MTheCoffeAdminPanel.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TheCoffeAdminPanel.Wpf.WindowsTheCoffeAdminPanel.Wpf.Windows  5   	   0    *TheCoffeAdminPanel.Wpf.Windows.LoginWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:TheCoffeAdminPanel.Wpf.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? WindowStyle$
  None=?5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	    ? 
ResizeMode$ CanMinimize=?5   	    ? ShowInTaskbar$ False??5   	   ???#082032 ? Title$ LoginWindow??5   	   $	??650??6   $
??1000??6*   .??5      ? .+?5   
   ?? $??	0,100,0,0q?6   $??Center=?6(   .+?5      ]? $	??350??6   $??5q?6$   .+?5      '  !MaterialDesignThemes.Wpf.PackIcon  $??Center=?5      
???????   Kind$ Coffee=?5      ?? 5      -   5         ??Name$ Username??5      $	??300??5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username??5      
??????? J? Opacity$	 0.8Q?5      5      ]? 5      $	??350??6   $??5q?6$   .+?5        $??Center=?5      
???????$ ImageDescription=?5!      G? 5"      -   5        	 G?Name$	 Password??5#      $	??300??5$      $ Password??5%      
???????$	 0.8Q?5'      5(      ?? 5)      $??Center=?6   
 ?? Orientation$
 
Horizontal=?66   .+?5*      ?? -   5         ??Name$ SaveBtn??5+      $	??250??5,      $??10q?5-      .??5/      ?? $
 
Horizontal=?6!   .+?50        $??25??51      $??25??52      $ ContentSaveOutline=?53      ?? 54      $??3q?55      $??Center=?56      $??Login??57      58      5:      ?? 5;      -   5        
???  ??.??5<        $ 	ExitToApp=?6"   5=      5>      5?      5@      5A      