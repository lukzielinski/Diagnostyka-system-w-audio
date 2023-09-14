function [] = audio_analysis(~)
[y, fs] = audioread('test1.wav');
y = y(:, 1);
N = length(y);
t = (0:N-1)/fs;

plot(t, y);
grid on;
xlabel('Time [s]');
ylabel('Amplitude');
title('Time waveform');

spectrogram(y, 1024, 512, 1024, fs, 'yaxis');
title('Frequency waveform');

w = hanning(N, 'periodic');
periodogram(y, w, N, fs, 'power');

histogram(y);
title('Sound pressure');