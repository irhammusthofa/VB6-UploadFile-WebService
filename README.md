# Upload File via Web Service from Visual Basic 6.0
Upload file via web service atau http/https dari visual basic 6.0. Webservice bisa dibuat menggunakan php,asp atau yang lainnya. 

<h1>Berikut ini cara menggunakannya :</h1></br>
<code>
call UpLoadData("C:/namafile.txt","https://domain.com/upload.php","nama_file.txt")  
</code></br>
ada tiga parameter pada fungsi <code>UpLoadData</code> yaitu :</br>
1. <code>strFilename</code> alamat file yang akan diupload</br>
2. <code>strTargetUrl</code> URL Webservice</br>
3. <code>namaFile</code> (Opsional) Nama File jika ingin diubah</br></br>

Post untuk Webservicenya : </br>
1. field String <code>filename</code></br>
2. field Attachment <code>gambar</code></br>
