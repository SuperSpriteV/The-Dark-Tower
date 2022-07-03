# Dark-Tower

Current Objecive. Fix jump ainmation
jump animation has been split into 3 parts. Rise fall and land
Jump_Rise to be played while upward acceleration is >0 (irrelevant)
Jump_fall to be played while upward acceleration<= 0
OR
Jump_fall to be played when upward accel= downward acelrtaion. and continues to play until downward accelration=0

make bool. [redacted] . Falling. Landed
Rising to be linked with upward accelartion (irrelevant)
Falling to be linked with downwawrd acceleration and upward accelration

AAnother approach. reference y axis
as long as pos y keeps on increasing. Jump_Rise will continue to play. (irrelevenat)
if pos y starts ddecreasing  play jump_fall 
pos y stops updating= play JUmp_Land

Edit. No need to make rising bool. Jumpnig (bool is already created) is enough for jump _rise to play
only 2 bools are neded Falling and Landed
bool (falling) will be used to transition from jump_rise. so until conditions of falling arent met rise will continue to play hence bool(rising) is not needed
