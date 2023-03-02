A = [1,1,3,1,0;
    2,1,3,0,0;
    0,0,1,2,0;
    0,1,2,0,0;
    0,1,3,0,1;
    0,0,1,0,1;
    0,0,2,2,1];
r = rank(A);
n = 0;
disp('rank:');
disp(r);
M = zeros(r);
disp('nonsingular submatrices:');
for x=0:3 % psh down
    for y=0:1 % psh right
        for i=x+1:r+x % matrix "M" creation
            for j=y+1:r+y
                M(i-x,j-y)=A(i,j);
            end
        end
        if abs(det(M))> 0.0001 % nonsingular req
            disp(M); % matrix print
            n = n + 1;
        end
    end
end
disp("nonsingular submatrices count: " + n);