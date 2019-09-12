﻿using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Bytewizer.Backblaze.Models;

namespace Bytewizer.Backblaze.Storage
{
    public interface IBackblazeStorage
    {
        IBackblazeFiles Files { get; }
        IBackblazeDirectories Directories { get; }
        IBackblazeBuckets Buckets { get; }
        IBackblazeKeys Keys { get; }
        IBackblazeParts Parts { get; }

        string AccountId { get; }

        bool IsDisposed { get; }
        void Dispose();

        Task<IApiResults<UploadFileResponse>> UploadAsync(string bucketId, string fileName, Stream content);
        Task<IApiResults<UploadFileResponse>> UploadAsync(string bucketId, string fileName, Stream content, IProgress<ICopyProgress> progress);
        Task<IApiResults<UploadFileResponse>> UploadAsync(string bucketId, string fileName, Stream content, CancellationToken cancel);
        Task<IApiResults<UploadFileResponse>> UploadAsync(string bucketId, string fileName, Stream content, IProgress<ICopyProgress> progress, CancellationToken cancel);
        Task<IApiResults<UploadFileResponse>> UploadAsync(UploadFileByBucketIdRequest request, Stream content);
        Task<IApiResults<UploadFileResponse>> UploadAsync(UploadFileByBucketIdRequest request, Stream content, IProgress<ICopyProgress> progress);
        Task<IApiResults<UploadFileResponse>> UploadAsync(UploadFileByBucketIdRequest request, Stream content, CancellationToken cancel);
        Task<IApiResults<UploadFileResponse>> UploadAsync(UploadFileByBucketIdRequest request, Stream content, IProgress<ICopyProgress> progress, CancellationToken cancel);

        Task<IApiResults<DownloadFileResponse>> DownloadByIdAsync(string fileId, Stream content);
        Task<IApiResults<DownloadFileResponse>> DownloadByIdAsync(string fileId, Stream content, IProgress<ICopyProgress> progress);
        Task<IApiResults<DownloadFileResponse>> DownloadByIdAsync(string fileId, Stream content, CancellationToken cancel);
        Task<IApiResults<DownloadFileResponse>> DownloadByIdAsync(string fileId, Stream content, IProgress<ICopyProgress> progress, CancellationToken cancel);
        Task<IApiResults<DownloadFileResponse>> DownloadByIdAsync(DownloadFileByIdRequest request, Stream content);
        Task<IApiResults<DownloadFileResponse>> DownloadByIdAsync(DownloadFileByIdRequest request, Stream content, IProgress<ICopyProgress> progress);
        Task<IApiResults<DownloadFileResponse>> DownloadByIdAsync(DownloadFileByIdRequest request, Stream content, CancellationToken cancel);
        Task<IApiResults<DownloadFileResponse>> DownloadByIdAsync(DownloadFileByIdRequest request, Stream content, IProgress<ICopyProgress> progress, CancellationToken cancel);

        Task<IApiResults<DownloadFileResponse>> DownloadAsync(string bucketName, string fileName, Stream content);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(string bucketName, string fileName, Stream content, IProgress<ICopyProgress> progress);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(string bucketName, string fileName, Stream content, CancellationToken cancel);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(string bucketName, string fileName, Stream content, IProgress<ICopyProgress> progress, CancellationToken cancel);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(DownloadFileByNameRequest request, Stream content);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(DownloadFileByNameRequest request, Stream content, IProgress<ICopyProgress> progress);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(DownloadFileByNameRequest request, Stream content, CancellationToken cancel);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(DownloadFileByNameRequest request, Stream content, IProgress<ICopyProgress> progress, CancellationToken cancel);
    }
}