function [] = record_audio()
Fs = 44100; 
channels_number = 1;
bits_number = 8;
recObj = audiorecorder(Fs, bits_number, channels_number);
disp('Recording has started');
recordblocking(recObj,6); 
disp('Recording finished!');
y = getaudiodata(recObj);
audiowrite('test1.wav', y, Fs);