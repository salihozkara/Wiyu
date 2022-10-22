import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Wiyu',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44301/',
    redirectUri: baseUrl,
    clientId: 'Wiyu_App',
    responseType: 'code',
    scope: 'offline_access Wiyu',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44300',
      rootNamespace: 'Wiyu',
    },
  },
} as Environment;
