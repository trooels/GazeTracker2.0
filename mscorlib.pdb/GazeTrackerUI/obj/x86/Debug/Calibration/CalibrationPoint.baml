   M S B A M L   `   `   `  ����  GazeTrackerUI2    ,GazeTrackerUI.CalibrationUI.CalibrationPoint   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      $
��Auto��5      $
��Auto��6     � 	Resources  5	         ScaleCalibrationPoint g� 	BeginTime �� 
TargetName �� TargetProperty O� KeyTime O� Value   ScaleCalibrationPointReverse��%L  &	        &	     �� 5
      .��5      U� $ 00:00:00X�6&   $ 
TargetGrid��6;   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6^   .\�5   
   �� $ 00:00:00��6   $ 1Q�62   �� 5   
   $ 00:00:01��6   $	 0.1Q�62   5   	   U� 5      $ 00:00:00X�6&   $ 
TargetGrid��6;   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6^   .\�5   
   �� $ 00:00:00��6   $ 1Q�62   �� 5   
   $ 00:00:01��6   $	 0.1Q�62   5   	   5      �� 5      .��5      U� $ 00:00:00X�6&   $ 
TargetGrid��6;   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6^   .\�5   
   �� $ 00:00:00��6   $	 0.1Q�62   �� 5   
   $ 
00:00:00.5��6   $ 1Q�64   5   	   U� 5      $ 00:00:00X�6&   $ 
TargetGrid��6;   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6^   .\�5   
   �� $ 00:00:00��6   $	 0.1Q�62   �� 5   
   $ 
00:00:00.5��6   $ 1Q�64   5   	   5      5        � Triggers 5"      :� 5#       :� RoutedEvent$+ %FrameworkElement.RequestBringIntoView��6   .[�5$      �� #��[  6   5%      .��5(      � -   5         �Name$ 
TargetGrid��5(   	   	 J� RenderTransformOrigin$	 0.5,0.5&�6D   z�5)      V� 5*      .~�5+      �� 
 �� ScaleX$
 1Q�6    �� ScaleY$ 1Q�6!   �� 5,      �� 5-      T� 5.      5/      .+�52      �� -   5         ��Name$ Image��52      $��Center=�6   $��8q�68   $��Center=�6C   $��Uniform=�6^   A� 53      -   5         A�Name$ Target��53      $��2q�6   
�������6)   A� 54      $��0q�6   
�������
���   �$��8��64   $��8��6>   $��Center=�6I   $��Center=�6f   55      57      