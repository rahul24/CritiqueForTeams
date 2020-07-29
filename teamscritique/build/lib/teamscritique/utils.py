import librosa
import soundfile
import os, glob, pickle
import numpy as np

def extract_feature(file_name, mfcc, chroma, mel):
    with soundfile.SoundFile(file_name) as sound_file:
        X = sound_file.read(dtype="float32")
        sample_rate=sound_file.samplerate
        if len(X.shape) > 1:
            X = X.mean(axis=1)
        if chroma:
            stft=np.abs(librosa.stft(X))
        result=np.array([])
        if mfcc:
            mfccs=np.mean(librosa.feature.mfcc(y=X, sr=sample_rate, n_mfcc=40).T, axis=0)
            result=np.hstack((result, mfccs))
        if chroma:
            chroma=np.mean(librosa.feature.chroma_stft(S=stft, sr=sample_rate).T,axis=0)
            result=np.hstack((result, chroma))
        if mel:
            mel=np.mean(librosa.feature.melspectrogram(X, sr=sample_rate).T,axis=0)
            result=np.hstack((result, mel))
    return result


emotions={
  '01': 0,
  '02': 0,
  '03': 0,
  '04':1,
  '05':1,
  '06':1,
  '07':1,
  '08':0
}
#DataFlair - Emotions to observe
observed_emotions=[0, 1]
emotionsToLables={
  0: 'non-negative',
    1: 'negative'
}
