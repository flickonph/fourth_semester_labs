ezplot('x^3-x', [-4 4]);
ezplot('sin(1/x^2)', [-2 2]);
ezplot('tan(x/2)');
axis([-pi pi -10 10])
ezplot('exp(-x^2/2)', [-1.5 1.5]);
hold on
ezplot('x^4-x^2', [-1.5 1.5]);
hold off
title 'y=exp(-x^2/2)|y=x^4-x^2';