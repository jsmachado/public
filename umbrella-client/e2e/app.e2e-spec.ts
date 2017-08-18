import { UmbrellaClientPage } from './app.po';

describe('umbrella-client App', () => {
  let page: UmbrellaClientPage;

  beforeEach(() => {
    page = new UmbrellaClientPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
