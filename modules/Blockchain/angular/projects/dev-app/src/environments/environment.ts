import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Blockchain',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44344/',
    redirectUri: baseUrl,
    clientId: 'Blockchain_App',
    responseType: 'code',
    scope: 'offline_access Blockchain',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44344',
      rootNamespace: 'Blockchain',
    },
    Blockchain: {
      url: 'https://localhost:44348',
      rootNamespace: 'Blockchain',
    },
  },
} as Environment;
