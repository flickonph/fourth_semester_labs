x = 2.5378;
y = 2.536;
delx = 0.0001;
dely = 0.001;
dx = 0.0000394;
dy = 0.000394;

disp("x: " + x);
disp("y: " + y);
disp("abs delta x: " + delx);
disp("abs delta y: " + dely);
disp("rel delta x: " + dx);
disp("rel delta y: " + dy);

s1 = x + y;
disp("s1:" + s1);

s2 = x - y;
disp("s2:" + s2);

dels1 = delx + dely;
disp("abs delta s1:" + dels1);

dels2 = delx - dely;
disp("abs delta s2:" + dels2);
