% 定义数据
original_success_rate = [20, 20, 20, 20, 40, 40, 40, 60, 100, 100];
new_success_rate = [56.68, 56.68, 56.68, 56.68, 76.68, 76.68, 76.68, 96.68, 100, 100];

% 将时间转换为秒
original_time = [2*60+32, 3*60+16, 2*60+15, 1*60+53, 3*60+47, 2*60+25, 2*60+38, 3*60+8, 3*60+2, 4*60+14];
new_time = [1*60+43, 2*60+14, 1*60+32, 1*60+17, 2*60+35, 1*60+39, 1*60+48, 2*60+8, 2*60+4, 2*60+53];

% 单因素方差分析 (ANOVA)
data = [original_success_rate, new_success_rate];
group = [ones(size(original_success_rate)), 2*ones(size(new_success_rate))];
[p, tbl, stats] = anova1(data, group);
title('ANOVA Analysis for Success Rate');

% 回归分析
x = [original_time, new_time]';
y = [original_success_rate, new_success_rate]';

mdl = fitlm(x, y);

% 输出回归结果
disp(mdl);

% 绘制图表
figure;
subplot(1, 3, 1);
plot(mdl);
title('Regression Analysis');
xlabel('Time (seconds)');
ylabel('Success Rate (%)');

subplot(1, 3, 2);
boxplot(data, group);
title('Boxplot of Success Rates');
xlabel('Group');
ylabel('Success Rate (%)');
xticklabels({'Original', 'New'});

subplot(1, 3, 3);
hold on;
scatter(original_time, original_success_rate, 'r', 'filled');
scatter(new_time, new_success_rate, 'b', 'filled');
legend('Original', 'New');
title('Scatter Plot of Time vs Success Rate');
xlabel('Time (seconds)');
ylabel('Success Rate (%)');
hold off;

% 保存图表
saveas(gcf, 'anova_regression_analysis.png');
