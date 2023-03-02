% 1
figure('name','Графики');
subplot(2, 2, 1);
x=linspace(-4,4);
Y=x.^3-x;
plot(x,Y,'g');
title('График x^3-x');
xlabel('Ось x');
ylabel('Ось y');
legend('x^3-x');
grid on;

% 2
subplot(2, 2, 2);
x=linspace(-2,2);
Y1=sin((1./x).^2);
plot(x,Y1,'b');
title('График sin((1/x)^2)');
xlabel('Ось x');
ylabel('Ось y');
legend('x^3-x');
grid on;


% 3
subplot(2, 2, 3);
x=linspace(-pi,pi);
Y=tan(x./2);
plot(x,Y,'r');
axis([-pi pi -10 10]);
title('График tan(x/2)');
xlabel('Ось x');
ylabel('Ось y');
legend('tan(x/2)');
grid on;


% 4
subplot(2, 2, 4);
x=linspace(-1.5,1.5);
Y=exp(((-x.^2)./2));
plot(x,Y,'r');
hold on;
Y=x.^4-x.^2;
plot(x,Y,'b');
title('График exp((-x^2)/2) и x^4-x^2');
xlabel('Ось x');
ylabel('Ось y');
legend('exp((-x^2)/2)','x^4-x^2');
grid on;

