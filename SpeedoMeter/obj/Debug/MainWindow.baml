   M S B A M L   `   `   `  ����F  BSpeedoMeter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SpeedoMeterSpeedoMeter  5   	       SpeedoMeter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SpeedoMeter     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��700��6)   
�������.��5	      � ���	#FF565656 � ColumnDefinitions 5
   
   .+�5   
   �� -   5         ��Name$ accelerateButton��5      $��
Accelerate��6+   $
��Left=�6@   $��
360,29,0,0q�6[   $	��Top=�6o   $	��301��6�   $	��140��6�   6�   �� 5   
   -   5        $ brakeButton��5      $��Brake��6'   $
��Left=�67   $��360,201,0,0q�6R   $	��Top=�6g   $	��301��6   $	��140��6�   6�   A� 5   
   $
��Left=�6   $��50, 50, 0, 0q�6-   
���   �$	��Top=�6R   $	��250��6j   $	��250��6v   ���	#FF3939396�   A� 5   
   $
��Left=�6   $��50, 50, 0, 0q�6-   
���   �$	��Top=�6R   $	��250��6j   $	��250��6v   ��5      �� 5       �� ImageSource$s mfile:///C:/Users/Bryan/Documents/Visual Studio 2015/Projects/SpeedoMeter/SpeedoMeter/speedometer_negative.png��6    j� Stretch$
 None=�6�    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterY$	 0.5Q�6-    �� CenterX$	 0.5Q�6;   �� 5       �� CenterY$	 0.5Q�6,   	 �� CenterX$		 0.5Q�6:   �� 5      
 �� CenterY$	
 0.5Q�6.    �� CenterX$	 0.5Q�6<   T� 5       T� Y$ -0.07Q�61   5      5      5!      �� 5#   
   -   5         ��Name$ backSpeedLabel��5#      $	��888��6(   ���	#FF505050$
��Left=�6M   $��149,229,0,0q�6h   $	��Top=�6}   $��26.667(�6�   $)��#/SpeedoMeter;component/#alarm clock)�6�   �� 5$   
   -   5        $ 
speedLabel��5$      $	��000��6$   ���	#FFAEFF00$
��Left=�6I   $��149,229,0,0q�6d   $	��Top=�6y   $��26.667(�6�   $)��#/SpeedoMeter;component/#alarm clock)�6�   �� 5(   
   	 �� X1$	 175��6   	 �� X2$ 82��6   	 �� Y1$	 175��6    	 �� Y2$	 247��6)   
���  ��$��2��6?   z�5)      V� 5*      .~�5+      �� -   5        	transform��$	 175Q�5+   9   $	
 175Q�6G    �� Angle$ 0Q�6U   5,      5.      �� 50   
   -   5        $ textBox��50      $	��0.0��6!   $
��Left=�6/   $��10,0,0,0q�6J   $	��Top=�6\   $��18.667(�6t   ���	#FFFFFFFF$��Eras ITC)�6�    � 	Resources 52   
    �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� 
TargetType��%�  '��       �� 53      " ��6    54      P� 55       �@J�IsMouseOver . . �56      ��  � �� �	#FFDDDDDD67   �� 57       � �� �	#FF44444467   �� 58       � �� �	#FFFFFFFF68   59      P� 5:       � �� . . �5;      ��  � �� �	#FF22222267   �� 5<       � �� �	#FFDDDDDD67   5=      P� 5>       �@J�IsMouseOver .  . �5?      ��  � �� �	#FFAAAAAA67   �� 5@       � �� �	#FF22222267   5A      .�5D      ��  � �� 5E      �� 5F      " ��6*   .R�5G      �� #��z��6%   ._�5H   "   �� $��Center=�63   $��Center=�6P   5I      5J      5L      5M      5N      5O      5P      