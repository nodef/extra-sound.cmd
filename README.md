Produce sound of specific frequency in Windows Console.
> 1. Download [exe file](https://github.com/cmdf/extra-sound/releases/download/1.0.0/esound.exe).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> esound <frequency> <time>

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: a 500Hz sound for 1s
> esound 500 1000

:: a 1kHz sound for 250ms
> esound 1000 250

:: silence for 10s
> esound 0 10000
```


[![cmdf](https://i.imgur.com/EYiYfwb.jpg)](https://cmdf.github.io)
