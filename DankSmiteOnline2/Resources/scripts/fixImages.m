clear
close all

items = dir('../Temp');
items = items(3:end);

for i = 1:length(items)
    map = [];
    [img, map] = imread([items(i).folder '\' items(i).name]);
    shape = size(map,1);
    if shape > 0
        img = ind2rgb(img,map);
    end
    img = imresize(img,[92 92]);
    imwrite(img,['C:\Users\Klopper\Desktop\DankSmite\Smite Icons\Items92\' items(i).name],'png')
end

%%
[fap, map] = imread([items(i).folder '\' items(i).name]);
%%
gg = ind2rgb(fap,map);
%%
imshow(img)